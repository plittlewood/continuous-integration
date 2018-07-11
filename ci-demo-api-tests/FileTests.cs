using ci_demo_api;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace ci_demo_api_tests
{
    public class FileTests
    {
        [Theory]
        [InlineData("file_one.txt")]
        [InlineData("file_two.txt")]
        public void When_FileExists_ReturnContent(string path)
        {
            string output = FileHelper.GetFileContents(path);

            Assert.NotEmpty(output);
        }

        [Theory]
        [InlineData("file_three.txt")]
        public void When_FileDoesNotExists_ThrowFileNotFoundException(string path)
        {
            Assert.Throws<FileNotFoundException>(() => FileHelper.GetFileContents(path));
        }
    }
}
