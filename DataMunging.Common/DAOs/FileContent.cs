namespace DataMunging.Common.DAOs
{
    /// <summary>
    /// Class <c>FileContent</c> is used to simplify managing the data. 
    /// RowId, <c>MaximumValue</c> and <c>MinimumValue</c> are all retrieved from .DAT files. 
    /// <c>Spread</c> is a calculated field based on the difference between <c>MaximumValue</c> and <c>MinimumValue</c>
    /// </summary>
    public class FileContent
    {
        public string RowId { get; set; }
        public int MaximumValue { get; set; }
        public int MinimumValue { get; set; }
        public int Spread { get; set; }
    }
}
