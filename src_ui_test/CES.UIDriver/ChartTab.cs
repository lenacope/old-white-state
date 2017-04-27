
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.TabItems;
using CESUIDriver.AutomationIDs;

namespace CESUIDriver
{
    public class ChartTab : TabUIElements
    {
        private TabPage _chartTab;
      
        public string AxisTitleFont
        {
            get { return GetFonts(AutoIDs.IDC_AXISFONT); }
        }

        public string AxisSubtitleFont
        {
            get { return GetFonts(AutoIDs.IDC_DETAILSFONT); }
        }
                
        public string TickFont
        {
            get { return GetFonts(AutoIDs.IDC_TICKFONT); }
        }

        public ChartTab(TabPage _tab)
        {
            _chartTab = _tab;
        }
        
        
        public string GetFonts(string autoID)
        {
            Label fontLabel = getLabel(autoID, _chartTab);
            return fontLabel.Text;
        }

    }
}
