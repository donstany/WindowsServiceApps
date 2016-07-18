using System;
using System.IO;
using System.ServiceProcess;

namespace SpyService
{
    public partial class Service1 : ServiceBase
    {
        private const string LogFilePath = @"C:\Users\User\Desktop\monitorSevice\log.txt";
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            if (!File.Exists(LogFilePath))
            {
                //StreamWriter class that allow to write on file
                StreamWriter sw = new StreamWriter(LogFilePath);
                sw.WriteLine("The folder was modified at " + DateTime.Now);
                sw.Close();
            }
            else
            //if file exist append to current file log.txt
            {
                File.AppendAllText(LogFilePath, "The folder was modified at " + DateTime.Now);
            }
        }

        //protected override void OnContinue()
        //{
        //}
    }
}
