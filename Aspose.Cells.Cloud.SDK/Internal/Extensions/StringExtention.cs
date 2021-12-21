

namespace Aspose.Cells.Cloud.SDK.Internal.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;
    internal static class StringExtention
    {
        internal static string GetFileFormat(this string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);            
            return string.IsNullOrEmpty(fileInfo.Extension)?null :fileInfo.Extension.Substring(1);
        }

        internal static Stream Base64StringToStream(this string value)
        {
            byte[] data = Convert.FromBase64String(value);
            MemoryStream memoryStream = new MemoryStream(data);
            return memoryStream;
        }
    }
}
