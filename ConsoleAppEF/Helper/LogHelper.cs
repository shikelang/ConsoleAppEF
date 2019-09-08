using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoPrescription.Helper
{
    public class LogHelper
    {
        /*
         context.Database.Log = (s) => LogHelper.SqlLog(s);  
             */

        //private static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");
        //private static readonly log4net.ILog badrequest = log4net.LogManager.GetLogger("badrequest");
        //public static void Error(string info)
        //{
        //    if (logerror.IsInfoEnabled)
        //        logerror.Info(info);
        //}

        //public static void Error(Exception ex)
        //{
        //    if (logerror.IsErrorEnabled)
        //        logerror.Error(ex);
        //}

        //public static void BadRequest(string info)
        //{
        //    if (badrequest.IsInfoEnabled)
        //        badrequest.Info(info);
        //}




        public static string _SqlLogPath
        {
            get { return @"E:\Project\ConsoleAppEF\ConsoleAppEF\Log\"; }
            //get { return System.Web.HttpContext.Current.Server.MapPath($@"/Log/SqlLog/"); }
        }

        public static void SqlLog(string sql)
        {
            try
            {
                var fullpath = $"{_SqlLogPath}{DateTime.Now.ToString("yyyyMMddHH")}.txt";
                if (!Directory.Exists(_SqlLogPath))
                    Directory.CreateDirectory(_SqlLogPath);
                using (StreamWriter streamWriter = System.IO.File.AppendText(fullpath))
                {
                    streamWriter.WriteAsync($"【{DateTime.Now.ToShortTimeString()}】{sql}");
                }
            }
            catch(Exception ex) 
            {
            }

        }
    }
}
