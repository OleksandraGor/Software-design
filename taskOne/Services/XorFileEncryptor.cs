using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using taskOne.Models;

namespace taskOne.Services
{
    public class XorFileEncryptor : IFileEncryptor
    {
        private const int BufferSize = 4096;

        public EncryptionResult Process(
     string inputPath,
     string outputPath,
     string key,
     Action<int> reportProgress)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            int keyIndex = 0;

            var stopwatch = Stopwatch.StartNew();

            using FileStream input = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
            using FileStream output = new FileStream(outputPath, FileMode.Create, FileAccess.Write);

            byte[] buffer = new byte[4096];
            long totalBytes = input.Length;
            long processedBytes = 0;

            int bytesRead;
            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                for (int i = 0; i < bytesRead; i++)
                {
                    buffer[i] ^= keyBytes[keyIndex];
                    keyIndex = (keyIndex + 1) % keyBytes.Length;
                }

                output.Write(buffer, 0, bytesRead);
                processedBytes += bytesRead;

                int percent = (int)(processedBytes * 100 / totalBytes);
                reportProgress?.Invoke(percent);
            }

            stopwatch.Stop();

            return new EncryptionResult
            {
                FileName = Path.GetFileName(outputPath),
                FileSize = output.Length,
                ElapsedTime = stopwatch.Elapsed
            };
        }

    }
}

