using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoSmartLife.DataAccess;
using GoSmartLife.DataAccess.DataContext;
using System.Data.SqlClient;

namespace GoSmartLife.ConsoleApp
{
    class DatabaseInitialize
    {
        private static string ExceptionLogFile = @"G:\MyApplication\GoSmartLife\GoSmartLife.HelpDocument\ExceptionLog.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing Database...");

            try
            {
                DataContext context = new DataContext();
                context.Database.Initialize(true);

                //AppUnit_User _unit = new AppUnit_User();
                
            }
            catch(SqlException sqlEx)
            {
                System.IO.File.AppendAllText(ExceptionLogFile, Environment.NewLine + Convert.ToString(DateTime.Now) + Environment.NewLine);
                System.IO.File.AppendAllText(ExceptionLogFile, "SQL Exception Message:" + sqlEx.Message + Environment.NewLine);
                System.IO.File.AppendAllText(ExceptionLogFile, "SQL Exception Stacktrace:" + sqlEx.StackTrace + Environment.NewLine);
            }
            catch(Exception ex)
            {
                System.IO.File.AppendAllText(ExceptionLogFile, Environment.NewLine + Convert.ToString(DateTime.Now) + Environment.NewLine);
                System.IO.File.AppendAllText(ExceptionLogFile, "Common Exception Message:" + ex.Message + Environment.NewLine);
                System.IO.File.AppendAllText(ExceptionLogFile, "Common Exception Stacktrace:" + ex.StackTrace + Environment.NewLine);
            }


            Console.WriteLine("Done...");
            Console.ReadLine();

            //ApplicationUnit unit = new ApplicationUnit();
            //unit.SaveChanges();
        }
    }
}
