using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using TestStack.White.UIItems.WindowStripControls;
using TestStack.White.Factory;
using System.Threading;
using System.Linq;
using TestStack.White.Utility;
using System;

namespace CESUIDriver
{
    public class MainWindow
    {
        private Window _visibleMainWindow;

        public Window VisibleMainWindow
        {
            get { return _visibleMainWindow; }
        }

        public MainWindow(Application application)
        {
            //gets main window which is the first window of the application
            _visibleMainWindow = Retry.For(() => application.GetWindows().First(), TimeSpan.FromSeconds(5));

        }
        //for winwows repo - not in use at the moment
        public MainWindow(Window window)
        {
            _visibleMainWindow = window;
        }
//

       public void openSettings(Window _mainWindow)
        {
            MenuBar applicationMenuBar = _mainWindow.MenuBar;
            applicationMenuBar.MenuItem("Tools", "Settings...").Click();
        }
    }
}

