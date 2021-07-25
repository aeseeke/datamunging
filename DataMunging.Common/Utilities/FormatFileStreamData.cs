using DataMunging.Common.DAOs;
using System.Collections.Generic;
using System.Linq;

namespace DataMunging.Common.Utilities
{
    /// <summary>
    /// Class <c>FormatFileStreamData</c> receives a string object and parses data
    /// </summary>
    public class FormatFileStreamData
    {
        /// <summary>
        /// Method <c>FormatFileData</c> uses the FileStreamReader output and formats it into a string array
        /// </summary>
        /// <param name="fileLocation"></param>
        /// <returns>fileRowSplit <c>string[]</c></returns>
        private string[] FormatFileData(string fileLocation)
        {
            string fileData = FileStreamReader.RetrieveFileData(fileLocation);
            string[] fileRowSplit =
                System.Text.RegularExpressions.Regex.Split(fileData.Trim(), "\\n+", System.Text.RegularExpressions.RegexOptions.None);

            return fileRowSplit;
        }

        /// <summary>
        /// Method <c>RetrieveSmallestSpread</c> calls <c>FormatDataFile</c> and interates through each row of the data.
        /// Then it moves the requested data into a <c>FileContent</c> class for ease of management.
        /// Finally it returns a string value for the requested data
        /// </summary>
        /// <param name="fileLocation"></param>
        /// <param name="minValColumn"></param>
        /// <param name="maxValColumn"></param>
        /// <returns>smallestSpread* <c>string</c></returns>
        public string RetrieveSmallestSpread(string fileLocation, int minValColumn, int maxValColumn)
        {
            var rawDataArray = FormatFileData(fileLocation);

            List<FileContent> spreadData = new List<FileContent>();

            foreach (string record in rawDataArray)
            {
                string[] rowData = System.Text.RegularExpressions.Regex.Split(record.Trim(), "\\s+", System.Text.RegularExpressions.RegexOptions.None);

                if (int.TryParse(rowData[0].Substring(0, 1), out _))
                {
                    int maxVal = int.Parse(rowData[maxValColumn].Substring(0, 2));
                    int minVal = int.Parse(rowData[minValColumn].Substring(0, 2));
                    int spreadVal = maxVal - minVal;

                    FileContent sanitizedRowData = new FileContent
                    {
                        RowId = rowData[0],
                        MaximumValue = maxVal,
                        MinimumValue = minVal,
                        Spread = spreadVal > 0 ? spreadVal : spreadVal * -1
                    };

                    spreadData.Add(sanitizedRowData);
                }
            }

            int smallestSpread = spreadData.Min(d => d.Spread);

            return $"{smallestSpread}";
        }
    }
}
