

namespace Aspose.Cells.Cloud.SDK.Internal.Extensions
{
    using System.IO;
    internal static class StreamExtention
    {
        /// <summary>
        ///     Copy a stream to destination stream
        /// </summary>
        /// <param name="source">The source stream</param>
        /// <param name="destination">The destination stream</param>
        /// <param name="bufferSize">The size of the buffer</param>
        internal static void CopyTo(this Stream source, Stream destination, int bufferSize = 81920)
        {
            if (source.CanSeek)
            {
                source.Flush();
                source.Position = 0;
            }

            var array = new byte[bufferSize];
            int count;
            while ((count = source.Read(array, 0, array.Length)) != 0)
                destination.Write(array, 0, count);
        }


        /// <summary>
        ///     ReadAsBytes
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static byte[] ReadAsBytes(this Stream input)
        {
            var buffer = new byte[16 * 1024];
            using (var ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                    ms.Write(buffer, 0, read);

                return ms.ToArray();
            }
        }
    }
}
