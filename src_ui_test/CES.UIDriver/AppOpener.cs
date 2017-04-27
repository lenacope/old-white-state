using System.Diagnostics;
using System.IO;
using System.Reflection;
using TestStack.White;

namespace CESUIDriver
{
    using System;

    public class AppOpener
    {
        private Application _application;  
        private const string _appPath = @"C:\Program Files (x86)\CES EduPack 2016\ces.exe";

        public Application Application 
        {
            get { return _application; } 
        }

        public AppOpener()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var codebase = new Uri(assembly.CodeBase);
            var basepath = Path.GetDirectoryName(codebase.LocalPath);

            string projectFilePath = Path.Combine(basepath,  @"Resources\Blank.ces");

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = _appPath;
            startInfo.Arguments = projectFilePath;
            startInfo.UseShellExecute = false;
            
            _application = Application.Launch(startInfo);

            WindowRepo.Init(_application); //for windows repository - not in use at the moment
        }

        public MainWindow GETMainWindow()
        {
            MainWindow mainWindow = new MainWindow(_application);
            return mainWindow;
        }
    }
}
