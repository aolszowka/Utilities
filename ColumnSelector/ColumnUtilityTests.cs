// -----------------------------------------------------------------------
// <copyright file="ColumnUtilityTests.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2014. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace ColumnSelector
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    [TestFixture]
    public class ColumnUtilityTests
    {
        /// <summary>
        /// The default column delimiter (Tab)
        /// </summary>
        private const char DEFAULT_COLUMN_DELIMITER = '\t';

        /// <summary>
        /// The default column index (0)
        /// </summary>
        private const int DEFAULT_COLUMN_INDEX = 0;

        #region GetColumnFromString

        [Test]
        public void GetColumnFromString_NullArgument_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ColumnUtility.GetColumnFromString(null, DEFAULT_COLUMN_DELIMITER, DEFAULT_COLUMN_INDEX));
        }

        [Test]
        public void GetColumnFromString_EmptyString_ArgumentException()
        {
            string testString = string.Empty;

            Assert.Throws<ArgumentException>(() => ColumnUtility.GetColumnFromString(testString, DEFAULT_COLUMN_DELIMITER, DEFAULT_COLUMN_INDEX));
        }

        #endregion

        #region GetColumnFromStrings

        [Test]
        public void GetColumnFromStrings_NullArgument_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ColumnUtility.GetColumnFromStrings(null, DEFAULT_COLUMN_DELIMITER, DEFAULT_COLUMN_INDEX).ToArray());
        }

        [Test]
        public void GetColumnFromStrings_EmptySet_ArgumentException()
        {
            IEnumerable<string> testSet = new string[1];

            Assert.Throws<ArgumentException>(() => ColumnUtility.GetColumnFromStrings(testSet, DEFAULT_COLUMN_DELIMITER, DEFAULT_COLUMN_INDEX).ToArray());
        }

        #endregion

        #region GetColumnFromStringSorted

        [Test]
        public void GetColumnFromStringSorted_NullArgument_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ColumnUtility.GetColumnFromStringSorted(null, DEFAULT_COLUMN_DELIMITER, DEFAULT_COLUMN_INDEX));
        }

        [Test]
        public void GetColumnFromStringSorted_EmptyString_ArgumentException()
        {
            string testString = string.Empty;

            Assert.Throws<ArgumentException>(() => ColumnUtility.GetColumnFromStringSorted(testString, DEFAULT_COLUMN_DELIMITER, DEFAULT_COLUMN_INDEX));
        }

        #endregion

        #region GetColumnFromStringsSorted

        [Test]
        public void GetColumnFromStringsSorted_NullArgument_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ColumnUtility.GetColumnFromStringsSorted(null, DEFAULT_COLUMN_DELIMITER, DEFAULT_COLUMN_INDEX).ToArray());
        }

        [Test]
        public void GetColumnFromStringsSorted_EmptySet_ArgumentException()
        {
            IEnumerable<string> testSet = new string[1];

            Assert.Throws<ArgumentException>(() => ColumnUtility.GetColumnFromStringsSorted(testSet, DEFAULT_COLUMN_DELIMITER, DEFAULT_COLUMN_INDEX).ToArray());
        }

        #endregion
    }
}
