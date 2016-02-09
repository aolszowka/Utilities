// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2015-2016. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace ScanForBadAssemblyVersion
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Toy program to scan the given directories for CLR assemblies and looks
    /// for those with "Bad Versions" (IE 0.0.0.0).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Entry Point
        /// </summary>
        /// <param name="args">The directories to scan.</param>
        static void Main(string[] args)
        {
            if (args.Length == 0 || args.Any(current => !Directory.Exists(current)))
            {
                string usageError =
                    "Invalid argument/Missing directory given.\n\n" +
                    "Scans an arbitrary number of paths (recursively) for CLR Assemblies and looks\n" +
                    "for those with bad versions (IE 0.0.0.0)\n\n" +
                    "Usage: ScanForBadAsssemblyVersion \"Path1\" \"Path2\"...";

                Console.WriteLine(usageError);
            }
            else
            {
                IEnumerable<string> executableTypes = GetExecutableTypes(args);
                IEnumerable<KeyValuePair<string, AssemblyName>> assemblyNames = GetAssemblyNames(executableTypes);

                // Finally filter to "bad" versions, IE the version is 0.0.0.0
                IEnumerable<string> badAssemblyVersions =
                    assemblyNames
                        .Where(currentAssembly => currentAssembly.Value.Version.ToString(4).Equals("0.0.0.0"))
                        .Select(currentAssembly => currentAssembly.Key);

                foreach (string badAssembly in badAssemblyVersions)
                {
                    Console.WriteLine(badAssembly);
                }
            }
        }

        /// <summary>
        /// Given a set of directories return all executable types (IE EXE and DLL) found recursively.
        /// </summary>
        /// <param name="targetDirectories">Directories to scan for executable types.</param>
        /// <returns>An Enumerable of paths to the executable types.</returns>
        private static IEnumerable<string> GetExecutableTypes(IEnumerable<string> targetDirectories)
        {
            if (targetDirectories == null)
            {
                throw new ArgumentNullException("targetDirectories");
            }

            // Holy Linq Abuse Batman! This isn't as bad as it looks,
            // basically we're just performing a search of every given
            // directory filtering for file names that end in .dll or
            // .exe
            return targetDirectories.SelectMany(currentTargetdirectory =>
                {
                    // This would be cleaner if EnumerateFiles allowed us to take
                    // multiple filters, however I only appear to be able to give
                    // a single filter and then must refilter it to get only exe
                    // and dll's
                    return Directory.EnumerateFiles(currentTargetdirectory, "*.*", SearchOption.AllDirectories)
                             .Where(currentFile =>
                                    {
                                        return currentFile.EndsWith(".dll", StringComparison.InvariantCultureIgnoreCase) ||
                                               currentFile.EndsWith(".exe", StringComparison.InvariantCultureIgnoreCase);
                                    });
                });
        }

        /// <summary>
        /// Given a list of executable types, first check to see if the type
        /// is a CLR executable, if so return the AssemblyName along with the
        /// path to the binary.
        /// </summary>
        /// <param name="assemblies">The files to scan.</param>
        /// <returns>A KeyValuePair where the Key is the path to the binary, and the value is an <see cref="T:System.Refleciton.AssemblyName"/>.</returns>
        /// <remarks>These binaries are loaded in an AppDomain to avoid growing the size of this binary.</remarks>
        private static IEnumerable<KeyValuePair<string, AssemblyName>> GetAssemblyNames(IEnumerable<string> assemblies)
        {
            if (assemblies == null)
            {
                throw new ArgumentNullException("assemblies");
            }

            foreach (string targetAssembly in assemblies)
            {
                // We need to load each assembly into its own AppDomain this
                // way we can unload the assembly once we're done and don't
                // incur the cost of having all of these assemblies loaded.
                // Also this should avoid any issues where we have multiple
                // assemblies loaded previously into the AppDomain, I recall
                // this being an issue, but can't recall why?
                AppDomainSetup ads = new AppDomainSetup();
                ads.ApplicationBase = Environment.CurrentDirectory;

                // This name needs to be unique
                string uniqueAppDomainName = Guid.NewGuid().ToString("N");
                AppDomain ad = AppDomain.CreateDomain(uniqueAppDomainName, null, ads);

                // This will be hosted in the AppDomain, and is "Remote"
                AssemblyLoaderRemote alr =
                    (AssemblyLoaderRemote)ad.CreateInstanceAndUnwrap(
                        Assembly.GetExecutingAssembly().FullName,
                        typeof(AssemblyLoaderRemote).FullName);

                if (alr.IsManagedAssembly(targetAssembly))
                {
                    AssemblyName assemblyName = alr.GetAssemblyName(targetAssembly);
                    yield return new KeyValuePair<string, AssemblyName>(targetAssembly, assemblyName);
                }

                // Trash this AppDomain
                AppDomain.Unload(ad);
            }
        }
    }
}
