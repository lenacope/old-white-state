using TestStack.White.UIItems.TabItems;

namespace CESUIDriver
{
    public class DatasheetTab : TabUIElements
    {
        private TabPage _datasheetTab;

        public DatasheetTab(TabPage _tab)
        {
            _datasheetTab = _tab;
        }
                
        public bool AreMultipleDatasheetsAllowed()
        {
            var multiDatasheet = getCheckbox("Allow more than one datasheet window", _datasheetTab);
            return (multiDatasheet.Checked);
        }

    }
}
