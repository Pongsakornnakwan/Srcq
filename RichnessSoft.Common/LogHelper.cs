using System;
using System.Collections.Generic;
using System.Text;

namespace RichnessSoft.Common
{
    public static class LogHelper
    {
        public enum FileFolder
        {
            LocalFile,
            SharedFile,
            PrivateFile,
        }
        public enum LogType { Info, Error }
        private static string gstrAppName = "RichnessSoft.Web";
        public static string gmLogFolder(FileFolder fileFolder)
        {
            return gmLogFolder(fileFolder, gstrAppName);
        }
        public static string gmLogFolder(FileFolder fileFolder ,string ApplicationName)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            switch (fileFolder)
            {
                case FileFolder.PrivateFile: //each user has their own personal settings
                    sb.Append(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                    break;
                case FileFolder.LocalFile:
                case FileFolder.SharedFile: //all users share the same settings
                    sb.Append(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
                    break;
            }
            return string.Format("{0}\\{1}\\{2}\\{3}", sb.ToString(), "RicnessSoft", ApplicationName, "LOG");
        }

        static Object objLock = new Object();
        public static void gmEventLog(FileFolder fileFolder, LogType logType, string strMsg, string strTask, string strSID)
        {
            string strFolder = LogHelper.gmLogFolder(fileFolder);

            lock (objLock)
            {
                string logFileName = strFolder + string.Format("\\{0}_{1}.LOG", gstrAppName, DateTime.Now.Date.ToString("yyyyMMdd"));
                string logPath = System.IO.Path.GetDirectoryName(logFileName);
                if (System.IO.Directory.Exists(logPath) == false) { System.IO.Directory.CreateDirectory(logPath); }
                System.IO.StreamWriter sw = null;
                try
                {
                    if (!System.IO.File.Exists(logFileName))
                        sw = System.IO.File.CreateText(logFileName);
                    else
                        sw = System.IO.File.AppendText(logFileName);
                    if (sw != null)
                    {
                        LogHelper.pmLog(sw, logType, strMsg, strTask, strSID);
                    }
                }
                finally { if (sw != null) { sw.Close(); } }
            }
        }

        public static void gmEventLog(LogType logType, string strMsg, string strTask, string strSID)
        {
            LogHelper.gmEventLog(FileFolder.LocalFile, logType, strMsg, strTask, strSID);
        }

        public static void gmEventLog(string fix_folder, LogType logType, string strMsg, string strTask, string strSID)
        {
            string strFolder = fix_folder;

            lock (objLock)
            {
                string logFileName = strFolder + string.Format("\\{0}_{1}.LOG", gstrAppName, DateTime.Now.Date.ToString("yyyyMMdd"));

                string logPath = System.IO.Path.GetDirectoryName(logFileName);
                if (System.IO.Directory.Exists(logPath) == false) { System.IO.Directory.CreateDirectory(logPath); }
                System.IO.StreamWriter sw = null;
                try
                {
                    if (!System.IO.File.Exists(logFileName))
                        sw = System.IO.File.CreateText(logFileName);
                    else
                        sw = System.IO.File.AppendText(logFileName);
                    if (sw != null)
                    {
                        LogHelper.pmLog(sw, logType, strMsg, strTask, strSID);
                    }
                }
                finally { if (sw != null) { sw.Close(); } }
            }
        }

        private static void pmLog(System.IO.StreamWriter w, LogType logType, string strMsg, string strTask, string strSID)
        {
            string strLogType = Enum.GetName(typeof(LogType), logType);
            System.Text.StringBuilder stb = new System.Text.StringBuilder();
            stb.AppendLine("\r\nType : " + strLogType);
            stb.AppendLine(strMsg);
            if (strTask != null && strTask.Trim().Length > 0) { stb.AppendLine("TASK : " + strTask); }
            if (strSID != null && strSID.Trim().Length > 0) { stb.AppendLine("SID : " + strSID); }
            LogHelper.pmLog(w, stb.ToString());
        }

        private static void pmLog(System.IO.StreamWriter w, string strMsg)
        {
            w.Write("DateTime[{0} {1}]", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
            w.WriteLine(strMsg);
            w.WriteLine("-------------------------------");
            w.Flush();
        }

        public static string gmGetErrMsg(Exception ex)
        {
            System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
            return string.Format("Message :{0}\r\nStack :{1}\r\nTarget :{2}\r\nMethod: {3} \r\nLine : {4} \r\nColumn : {5}", ex.Message, ex.StackTrace, ex.TargetSite, trace.GetFrame(0).GetMethod().Name, trace.GetFrame(0).GetFileLineNumber(), trace.GetFrame(0).GetFileColumnNumber());
        }
    }
}
