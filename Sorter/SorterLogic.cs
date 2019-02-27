// -----------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2014-2019. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Sorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    static class SorterLogic
    {
        /// <summary>
        /// Given an "Input String" that is delimited by newline characters
        /// </summary>
        /// <param name="inputString">The "Input String" as described below.</param>
        /// <param name="sortDescending">Indicates that the result should be returned in descending order.</param>
        /// <param name="distinctInputs">Indicates that the result should only include the distinct elements.</param>
        /// <returns>An "Output String" that is delimited by newline characters.</returns>
        /// <remarks>
        ///     The "Input String" and "Output String" are just a plain old
        /// string that stores several inputs, delimited by a newline.
        /// </remarks>
        internal static string SortInput(string inputString, bool sortDescending, DistinctOptions distinctInputs)
        {
            // TODO: This method needs to be re-factored and abstracted into its own library!

            // Parse the Input String
            IEnumerable<string> inputs = _ParseInputString(inputString);

            // Perform the Actual Sorting/Distinct
            IEnumerable<string> outputs = SortInput(inputs, sortDescending, distinctInputs);

            // Rebuild the output string
            StringBuilder sb = new StringBuilder();
            foreach (string output in outputs)
            {
                sb.AppendLine(output);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Given an Enumerable of strings, filter them according to the arguments.
        /// </summary>
        /// <param name="inputs">The input to filter.</param>
        /// <param name="sortDescending">Indicates that the result should be returned in descending order.</param>
        /// <param name="distinctInputs">Indicates the result distinct filtering options.</param>
        /// <returns>An Enumerable that is filtered according to the arguments.</returns>
        internal static IEnumerable<string> SortInput(IEnumerable<string> inputs, bool sortDescending, DistinctOptions distinctInputs)
        {
            IEnumerable<string> outputs = inputs;

            // Determine if we should only return distinct
            if (distinctInputs != DistinctOptions.None)
            {
                if (distinctInputs == DistinctOptions.CaseSensitive)
                {
                    outputs = outputs.Distinct();
                }
                else if (distinctInputs == DistinctOptions.CaseInsensitive)
                {
                    outputs = outputs.Distinct(StringComparer.InvariantCultureIgnoreCase);
                }
                else
                {
                    string exception = $"There was a new enumeration added to {nameof(DistinctOptions)} this code needs to be updated.";
                    throw new InvalidOperationException(exception);
                }
            }

            // Sort the inputs
            if (sortDescending)
            {
                outputs = outputs.OrderByDescending(input => input);
            }
            else
            {
                outputs = outputs.OrderBy(input => input);
            }

            return outputs;
        }

        /// <summary>
        /// Parses the "Input String" as defined below and then delineates it to a IEnumerable of strings.
        /// </summary>
        /// <param name="inputString">The "Input String" to parse.</param>
        /// <returns>An Enumerable that represent the Inputs.</returns>
        /// <remarks>
        ///     The "Input String" is just a plain old string that stores
        /// several inputs, delimited by a newline.
        /// </remarks>
        internal static IEnumerable<string> _ParseInputString(string inputString)
        {
            return
                inputString.Split(new string[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
