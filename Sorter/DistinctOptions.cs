// -----------------------------------------------------------------------
// <copyright file="DistinctOptions.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2019. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Sorter
{
    /// <summary>
    /// Enumeration to indicate the distinct settings.
    /// </summary>
    enum DistinctOptions
    {
        // The output should not be filtered at all
        None,
        // The output should be filtered; respecting case
        CaseSensitive,
        // The output should be filtered; ignoring case
        CaseInsensitive
    }
}
