using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using taskOne.Models;



namespace taskOne.Services
{
    public interface IFileEncryptor
    {
        EncryptionResult Process(
            string inputPath,
            string outputPath,
            string key,
            Action<int> reportProgress);
    }
}

