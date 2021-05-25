using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Domain.Test
{
    public class FileNameGeneratorTest
    {

        [Theory]
        [InlineData("file.pdf",  0)]
        [InlineData("file_1.pdf",  1)]
        [InlineData("file_99.pdf",  99)]
        public void FileName_Valid_VersionId(string fileName, int expectedVersionId)
        {
            //Arrange and Act
            FileNameGenerator methodUnderTest = new FileNameGenerator(fileName);

            //Assert

            Assert.Equal(expectedVersionId , methodUnderTest.VersionId);
        }


        [Theory]
        [InlineData("file.pdf", "file")]
        [InlineData("file_1.pdf", "file_1")]
        [InlineData("file_99.pdf", "file_99")]
        public void FileName_Valid_FileName(string fileName, string expectedName)
        {
            //Arrange and Act
            FileNameGenerator methodUnderTest = new FileNameGenerator(fileName);

            //Assert

            Assert.Equal(expectedName, methodUnderTest.FileName);
        }

    }
}
