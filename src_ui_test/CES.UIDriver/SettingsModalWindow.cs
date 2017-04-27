using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.TabItems;
using TestStack.White.UIItems.WindowItems;

namespace CESUIDriver
{
    public class SettingsModalWindow
    {
        private Window _childWindow;
        
        private TabPage _tab;
        public TabPage Tab
        { 
         get { return _tab; }
        }   
    
    public SettingsModalWindow(Window mainWindow)
    {
        _childWindow = mainWindow.ModalWindow("Settings");
    }

     public void openTab(string tabName)
     {
        _tab = _childWindow.Get<TabPage>(SearchCriteria.ByText(tabName));
        _tab.Click();
     }
           
    }
}
