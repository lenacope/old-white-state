using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;

namespace CESUIDriver
{
    public static class WindowRepo
    {
        private static Application _application;
       
        public static MainWindow Main
        {
            get
            {
                Window _window = GetWindow("Blank - CES EduPack 2016 - [Home]");
                return new MainWindow(_window);
            }
            
        }

        
        public static void Init(Application application)
        {
            _application = application;
        }

        private static Window GetWindow(string title)
        {
            //return Retry.For(()=> _application.GetWindows().First(x=>x.Title.Contains(title)), TimeSpan.FromSeconds(5));
            return _application.GetWindow(title, InitializeOption.NoCache);

            

        }



    }
}
