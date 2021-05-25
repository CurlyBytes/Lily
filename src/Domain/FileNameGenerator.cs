using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Domain
{
    public sealed class FileNameGenerator
    {
        public string FileName { get; private set; }

        public int VersionId { get; private set; }

        private const string _fileNameExtension = ".pdf";

        private const int _emptyVersionId = 0;

        public FileNameGenerator(string fileName) 
        {
            GetVersionId(fileName);
            GetFileName(fileName);
        }


        private void GetVersionId(string fileName)
        {

            string removeextension = string.Concat(fileName.Reverse().Skip(4).Reverse());
            string digitalstring = string.Empty;

            for (int i = 0; i < removeextension.Length; i++)
            {
                if (Char.IsDigit(removeextension[i]))
                    digitalstring += removeextension[i];
            }

            if (String.IsNullOrEmpty(digitalstring))
            {
                VersionId = _emptyVersionId;
            }
            else 
            {
                VersionId = Int32.Parse(digitalstring);
            }
        
        }

        private void GetFileName(string fileName)
        {

            string revisefilename = fileName.Replace(_fileNameExtension, "");

            FileName = revisefilename;
        }


    }
}
