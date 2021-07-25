using System.IO;
using System.Text;

namespace DataMunging.Common.Utilities
{
    /// <summary>
    /// Class <c>FileStreamReader</c> retrieves data from a .DAT file via <c>StreamReader</c>
    /// </summary>
    public class FileStreamReader
    {
        /// <summary>
        /// Method <c>RetrieveFileData</c> retrieves data from a file and puts it into a string object
        /// </summary>
        /// <param name="fileLocation"></param>
        /// <returns>content <c>string</c></returns>
        public static string RetrieveFileData(string fileLocation)
        {
            string content = string.Empty;
            using (StreamReader reader = new StreamReader(fileLocation, Encoding.Default))
            {
                content = reader.ReadToEnd();
            }     

            return content;
        }

        
    }
}
