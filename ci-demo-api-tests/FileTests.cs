using ci_demo_api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ci_demo_api_tests
{
    [TestClass]
    public class FileTests
    {
        // Theories allow parameters to be passed to tests. The method below will generate two tests
        [TestMethod]
        [DataRow("file_one.txt")]
        [DataRow("file_two.txt")]
        public void When_FileExists_ReturnContent(string path)
        {
            string output = FileHelper.GetFileContents(path);

            Assert.AreNotEqual("", output);
        }

        [TestMethod]
        [DataRow("file_one.txt")]
        [DataRow("file_three.txt")]
        [ExpectedException(typeof(FileNotFoundException), "A FileNotFoundException was not thrown as expected")]
        public void When_FileDoesNotExists_ThrowFileNotFoundException(string path)
        {
            FileHelper.GetFileContents(path);
        }
    }
}
