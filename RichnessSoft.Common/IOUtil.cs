using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Common
{
    public class IOUtil
    {
        public static bool FileIsLocked(string strFilePath)
        {
            try
            {
                FileInfo fi = new(strFilePath);
                using FileStream stream = fi.Open(FileMode.Open, FileAccess.Read, FileShare.None);
                stream.Close();
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            //file is not locked
            return false;
        }
        public static bool FileExist(string strFilePath)
        {
            return File.Exists(strFilePath);
        }
        public static bool DirectoryExist(string strDirectoryPath)
        {
            return Directory.Exists(strDirectoryPath);
        }
        public static bool DeleteFile(string strFilePath)
        {
            try
            {
                if (FileExist(strFilePath) && FileIsLocked(strFilePath) == false)
                {
                    File.Delete(strFilePath);
                }
            }
            catch (Exception)
            {
                return false;
            }
            
            return true;
        }
        public static bool DeleteDirectory(string strDirectoryPath)
        {
            try
            {
                if (DirectoryExist(strDirectoryPath))
                {
                    Directory.Delete(strDirectoryPath);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool WriteFile(MemoryStream memoryStream , string strFilePath)
        {
            try
            {
                using MemoryStream ms = memoryStream;
                using (FileStream fs = new(strFilePath, FileMode.Create, FileAccess.Write))
                {
                    ms.WriteTo(fs);
                    fs.Close();
                }
                ms.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
            
        }
        public static bool WriteFile(Stream inputStream , string strFilePath)
        {
            try
            {
                using (FileStream fs = new(strFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    inputStream.CopyTo(fs);
                    fs.Flush();
                    fs.Close();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
            
        }
    }
}
