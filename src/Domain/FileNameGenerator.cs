using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public sealed class FileNameGenerator
    {
        public string FileName { get; private set; }

        public int VersionId { get; private set; }

        private const string _fileNameExtension  = ".pdf";

        private const string _fileNameSeparator = "_";

        public FileNameGenerator(string fileName, int versionId) 
        {
            FileName = fileName;
            VersionId = versionId;            
        }


        public override string ToString()
        {
            return GenerateFileName(FileName, VersionId) + _fileNameExtension;
        }

        private string GenerateFileName(string fileName, int versionId)
        {
            if (versionId == 0)
            {
                return fileName;
            }

            return fileName + _fileNameSeparator + versionId;
        }


    }
}
