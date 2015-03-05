using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DictionaryFilter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// EventHander for when the Input TextBoxes Change.
        /// </summary>
        /// <param name="sender">The object that invoked this event.</param>
        /// <param name="e">The arguments to this event.</param>
        private void OnInputsChanged(object sender, EventArgs e)
        {
            textBoxOutput.Text = "Processing...";

            string output = _PerformDictionaryFilter(textBoxInput.Text, textBoxFilter.Text);

            // Set our text
            textBoxOutput.Text = output;
        }

        private static string _PerformDictionaryFilter(string inputDictionaryString, string filterString)
        {
            char delimiter = '\t';

            IDictionary<string, string> inputDictionary = _ParseInputDictionaryString(inputDictionaryString, delimiter);
            IEnumerable<string> filters = _ParseFilter(filterString);

            StringBuilder sb = new StringBuilder();
            foreach (string filter in filters)
            {
                if (inputDictionary.ContainsKey(filter))
                {
                    string value = inputDictionary[filter];

                    // We don't have to include the delimiter, because
                    // the "value" contains the original delimiter
                    string reconstitutedValue = string.Format("{0}{1}", filter, value);
                    sb.AppendLine(reconstitutedValue);
                }
                else
                {
                    string errorMessage = string.Format("Key {0} was not found. Processing has stopped.", filter);
                    sb = new StringBuilder(errorMessage);
                    break;
                }
            }

            return sb.ToString();
        }

        /// <summary>
        ///     Given a "Dictionary String", which is defined as a string
        /// that has the Dictionary KeyValuePairs delimited by the specified
        /// delimiter and the entities delimited by NewLines. Parse or
        /// "de-serialize" the string into a proper dictionary.
        /// </summary>
        /// <param name="inputDictionaryString">The "Dictionary String" to parse.</param>
        /// <param name="delimiter">The KeyValuePair Delimiter.</param>
        /// <returns>A Dictionary that represents the given "Dictionary String".</returns>
        /// <remarks>
        ///    Note the KeyValuePair delimiter will consider the first instance
        /// of the delimiter to indicate the delineation. This means that any
        /// additional instances of the delimiter within the entity (as
        /// determined by NewLine) are considered part of the "Value".
        /// </remarks>
        private static IDictionary<string, string> _ParseInputDictionaryString(string inputDictionaryString, char delimiter)
        {
            IDictionary<string, string> returnDictionary = new Dictionary<string, string>();

            // Split the input string on the new line character first
            var dictionaryEntryStrings =
                inputDictionaryString.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Now create the dictionary, currently the "Key" is assumed
            // to be the value up until the first Tab, the remainder is
            // the "Value"
            foreach (string dictionaryEntryString in dictionaryEntryStrings)
            {
                Tuple<string, string> dictionaryEntry = _ParseDictionaryEntry(dictionaryEntryString, delimiter);

                // Because this is user input we can't guarantee that we
                // were given a legitimate dictionary we need to perform
                // this check to make sure we don't have collisions.
                if (returnDictionary.ContainsKey(dictionaryEntry.Item1))
                {
                    string errorMessage =
                        string.Format("The Key `{0}` already existed in the input Dictionary", dictionaryEntry.Item1);
                    throw new ArgumentException(errorMessage);
                }
                else
                {
                    returnDictionary.Add(dictionaryEntry.Item1, dictionaryEntry.Item2);
                }
            }

            return returnDictionary;
        }

        /// <summary>
        ///     Given a Dictionary Entry (A string that contains at least one
        /// delimiter), split the string into the appropriate [Key,Value] pair.
        /// </summary>
        /// <param name="dictionaryEntryString">A string which represents a [Key,Value] pair delimited by the specified delimiter.</param>
        /// <param name="delimiter">The specified delimiter.</param>
        /// <returns>A Tuple that contains the [Key,Value] pair.</returns>
        private static Tuple<string, string> _ParseDictionaryEntry(string dictionaryEntryString, char delimiter)
        {
            int delimiterIndex = dictionaryEntryString.IndexOf(delimiter);

            if (delimiterIndex < 0)
            {
                string errorMessage =
                    string.Format("The specified delimiter `{0}` was not found in entry `{1}`", delimiter, dictionaryEntryString);
                throw new ArgumentException(errorMessage);
            }

            string key = dictionaryEntryString.Substring(0, delimiterIndex);
            string value = dictionaryEntryString.Substring(delimiterIndex);

            return new Tuple<string, string>(key, value);
        }

        /// <summary>
        /// Given a NewLine delimited list of filters, return the unique filters as an IEnumerable.
        /// </summary>
        /// <param name="filterInputString">The filter string, delimited by NewLine.</param>
        /// <returns>The distinct filters, in an Enumerable form.</returns>
        private static IEnumerable<string> _ParseFilter(string filterInputString)
        {
            // Split the input string on the new line character first
            var allFilters =
                filterInputString.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // We just want the distinct filters
            var distinctFilters = allFilters.Distinct();

            return distinctFilters;
        }
    }
}
