// -----------------------------------------------------------------------
// <copyright file="ColumnSelectorOptions.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2014. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace ColumnSelector
{
    using System.ComponentModel;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ColumnSelectorOptions : INotifyPropertyChanged
    {
        /// <summary>
        /// Private backing store for the ColumnToSelect Property.
        /// </summary>
        private int columnToSelect;

        /// <summary>
        /// Private backing store for the ColumnDelimiter Property.
        /// </summary>
        private char columnDelimiter;

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the Column to Select.
        /// </summary>
        public int ColumnToSelect
        {
            get
            {
                return this.columnToSelect;
            }

            set
            {
                if (this.columnToSelect != value)
                {
                    this.columnToSelect = value;
                    this.OnPropertyChanged("ColumnToSelect");
                }
            }
        }

        /// <summary>
        /// Gets or sets the Column Delimiter.
        /// </summary>
        public char ColumnDelimiter
        {
            get
            {
                return this.columnDelimiter;
            }

            set
            {
                if (this.columnDelimiter != value)
                {
                    this.columnDelimiter = value;
                    this.OnPropertyChanged("ColumnDelimiter");
                }
            }
        }

        /// <summary>
        /// Method invoked on any property change.
        /// </summary>
        /// <param name="name">The name of the property changed.</param>
        public void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        /// <summary>
        /// Performs a Deep Copy of this Class.
        /// </summary>
        /// <returns>A deep copy of this instance.</returns>
        public ColumnSelectorOptions Clone()
        {
            return new ColumnSelectorOptions()
            {
                ColumnToSelect = this.ColumnToSelect,
                ColumnDelimiter = this.ColumnDelimiter
            };
        }
    }
}
