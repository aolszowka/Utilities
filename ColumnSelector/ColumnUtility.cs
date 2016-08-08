// -----------------------------------------------------------------------
// <copyright file="ColumnUtility.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2014-2016. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace ColumnSelector
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Utility class for manipulating text input to retrieve columns.
    /// </summary>
    public class ColumnUtility
    {
        /// <summary>
        ///     Takes a string and splits on Environment.NewLine to determine
        /// the Rows to operate on. Returns the specified "column", which is
        /// based on the given delimiter.
        /// </summary>
        /// <param name="inputString">The input rows that are delimited on <see cref="System.Environment.NewLine"/> or LF character.</param>
        /// <param name="columnDelimiter">The column delimiter.</param>
        /// <param name="columnIndex">The zero-based column index to return.</param>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable{T}"/> of <see cref="T:System.String"/> of the specified column for each of the input rows.</returns>
        public static IEnumerable<string> GetColumnFromString(string inputString, char columnDelimiter, int columnIndex)
        {
            if (string.IsNullOrWhiteSpace(inputString))
            {
                throw new ArgumentException("inputString");
            }

            string[] inputRows =
                inputString.Split(new string[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries);

            return GetColumnFromStrings(inputRows, columnDelimiter, columnIndex);
        }

        /// <summary>
        ///     Returns the specified "column", which is based on the given
        /// delimiter.
        /// </summary>
        /// <param name="inputs">The inputs to parse.</param>
        /// <param name="columnDelimiter">The column delimiter.</param>
        /// <param name="columnIndex">The zero-based column index to return.</param>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable{T}"/> of <see cref="T:System.String"/> of the specified column for each of the inputs.</returns>
        public static IEnumerable<string> GetColumnFromStrings(IEnumerable<string> inputs, char columnDelimiter, int columnIndex)
        {
            if (inputs == null || !inputs.Any(anyString => !string.IsNullOrWhiteSpace(anyString)))
            {
                throw new ArgumentException("inputRows");
            }

            foreach (string input in inputs)
            {
                string[] tokenizedRow = input.Split(new char[] { columnDelimiter });
                yield return tokenizedRow[columnIndex];
            }
        }

        /// <summary>
        ///     Takes a string and splits on Environment.NewLine to determine
        /// the Rows to operate on. Returns the specified "column", which is
        /// based on the given delimiter. Sorts the output in descending order.
        /// </summary>
        /// <param name="inputString">The input rows that are delimited on <see cref="System.Environment.NewLine"/>.</param>
        /// <param name="columnDelimiter">The column delimiter.</param>
        /// <param name="columnIndex">The zero-based column index to return.</param>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable{T}"/> of <see cref="T:System.String"/> of the specified column for each of the input rows.</returns>
        public static IEnumerable<string> GetColumnFromStringSorted(string inputString, char columnDelimiter, int columnIndex)
        {
            return GetColumnFromString(inputString, columnDelimiter, columnIndex).OrderBy(columnValue => columnValue);
        }

        /// <summary>
        ///     Returns the specified "column", which is based on the given
        /// delimiter. Sorts the output in descending order.
        /// </summary>
        /// <param name="inputs">The inputs to parse.</param>
        /// <param name="columnDelimiter">The column delimiter.</param>
        /// <param name="columnIndex">The zero-based column index to return.</param>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable{T}"/> of <see cref="T:System.String"/> of the specified column for each of the inputs.</returns>
        public static IEnumerable<string> GetColumnFromStringsSorted(IEnumerable<string> inputs, char columnDelimiter, int columnIndex)
        {
            return GetColumnFromStrings(inputs, columnDelimiter, columnIndex).OrderBy(columnValue => columnValue);
        }
    }
}
