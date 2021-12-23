namespace Aspose.Cells.Cloud.SDK.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class ConversionRequest
    {
        /// <summary>
        /// The full filename of input file.
        /// </summary>
        public string InputPath { get; set; }
        /// <summary>
        /// The full filename of output file.
        /// </summary>
        public string OutputPath { get; set; }
        /// <summary>
        ///  Password for opening an encrypted excel file.
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// when the value of SaveToCloud is true, converted result file save to Aspose Cloud. Default value is null 
        /// </summary>
        public bool? SaveToCloud { get; set; }
        /// <summary>
        /// Aspose Cloud storage name.
        /// </summary>
        public string StorageName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public Model.SaveOptions SaveOptions { get; set; }
    }
}
