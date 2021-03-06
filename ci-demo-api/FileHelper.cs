﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ci_demo_api_tests
{
    public static class FileHelper
    {
        public static string GetFileContents(string path)
        {
            string fullPath = $@"C:/APIFiles/{path}";

            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException($"Could not find file {fullPath}");
            }

            return File.ReadAllText(fullPath);
        }
    }
}
