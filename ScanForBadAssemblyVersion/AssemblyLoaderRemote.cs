// -----------------------------------------------------------------------
// <copyright file="AssemblyLoaderRemote.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2015. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace ScanForBadAssemblyVersion
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>
    ///     A remote-able class to interrogate CLR Assemblies, the idea is that
    /// you'll throw this in its own AppDomain to avoid any issues with loading
    /// and unloading multiple assemblies.
    /// </summary>
    public class AssemblyLoaderRemote : MarshalByRefObject
    {
        /// <summary>
        ///     Given a target assembly, return an enumerable of the names
        /// of the referenced assemblies.
        /// </summary>
        /// <param name="targetAssembly">The assembly to return the references for.</param>
        /// <returns>An enumerable of <see cref="T:System.Reflection.AssemblyName"/></returns>
        public IEnumerable<AssemblyName> GetReferencedAssemblies(string targetAssembly)
        {
            if (string.IsNullOrWhiteSpace(targetAssembly))
            {
                throw new ArgumentException("targetAssembly");
            }

            Assembly asm = Assembly.ReflectionOnlyLoadFrom(targetAssembly);

            if (asm != null)
            {
                foreach (AssemblyName assemblyName in asm.GetReferencedAssemblies())
                {
                    yield return assemblyName;
                }
            }
        }

        /// <summary>
        /// Given a target assembly return its name.
        /// </summary>
        /// <param name="targetAssembly">The assembly to get the name of.</param>
        /// <returns>The <see cref="T:System.Reflection.AssemblyName"/> of the target assembly.</returns>
        public AssemblyName GetAssemblyName(string targetAssembly)
        {
            if (string.IsNullOrWhiteSpace(targetAssembly))
            {
                throw new ArgumentException("targetAssembly");
            }

            Assembly asm = Assembly.ReflectionOnlyLoadFrom(targetAssembly);
            return asm.GetName();
        }

        /// <summary>
        /// Given a target file, determine if it is a managed (CLR) assembly.
        /// </summary>
        /// <param name="targetAssembly">The assembly to determine if it is a CLR assembly or not.</param>
        /// <returns><c>true</c> if it is a CLR Assembly; otherwise, <c>false</c>.</returns>
        public bool IsManagedAssembly(string targetAssembly)
        {
            if (string.IsNullOrWhiteSpace(targetAssembly))
            {
                throw new ArgumentException("targetAssembly");
            }

            // Because we're using ReflectionOnlyLoad we should be able to
            // avoid any issues with x64 assemblies running from a 32bit land
            try
            {
                Assembly.ReflectionOnlyLoadFrom(targetAssembly);
                return true;
            }
            catch (System.BadImageFormatException)
            {
                return false;
            }
        }
    }
}
