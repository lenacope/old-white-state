using TestStack.White.UIItems.TabItems;

namespace CESUIDriver
{
    public class LanguageTab : TabUIElements
    {
        private TabPage _langTab;
                
        public string AppLanguage
        {
            get { return getAppLanguage("Language"); }
          
        } 


        public LanguageTab(TabPage _tab)
        {
            _langTab = _tab;
        }
                       
        public string getAppLanguage(string Name)
        {
            return getCombobox(Name, _langTab);
            
        }

    }
}
