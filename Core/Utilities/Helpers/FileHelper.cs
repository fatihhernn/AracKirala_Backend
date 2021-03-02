using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            
            var sourcepath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(sourcepath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
           
            string destFileName = CreateNewFilePath(file);
            File.Move(sourcepath, destFileName);
            return destFileName;
        }
        public static void Delete(string path)
        {
            File.Delete(path);
        }
        public static string Update(string sourcePath, IFormFile file)
        {
            var result = CreateNewFilePath(file);

            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream(result, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return result;
        }
        public static string CreateNewFilePath(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string fileExtension = fileInfo.Extension;

            //burayı elimizle manuel oluşturduk.
            string path = Environment.CurrentDirectory + @"\Images\carImages";
            if (path==null)
            {
                File.Create(Environment.CurrentDirectory + @"\Images\carImages");
            }
            var newPath = Guid.NewGuid().ToString()  + fileExtension;

            string result = $@"{path}\{newPath}";

            return result;
        }
    }
}
