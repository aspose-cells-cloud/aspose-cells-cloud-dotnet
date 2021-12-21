namespace Aspose.Cells.Cloud.SDK.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class MergeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public string[] InputFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OutputPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? SaveToCloud { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string StorageName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? mergeToOneSheet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Model.SaveOptions SaveOptions { get; set; }
    }
}
