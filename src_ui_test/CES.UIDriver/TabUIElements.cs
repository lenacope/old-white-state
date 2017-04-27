using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.TabItems;
using TestStack.White.UIItems.ListBoxItems;

namespace CESUIDriver
{
    public class TabUIElements
    {
        public CheckBox getCheckbox(string checkBoxname, TabPage _tab)
        {
            CheckBox _multiDatasheet = _tab.Get<CheckBox>(SearchCriteria.ByText(checkBoxname));
            return _multiDatasheet;
        }

        public string getCombobox(string comboboxName, TabPage _tab)
        {
            ComboBox combobox = _tab.Get<ComboBox>();
            string _comboboxValue = combobox.SelectedItemText;
            return _comboboxValue;
        }

        public Label getLabel(string constAutoID, TabPage _tab)
        {
           return _tab.Get<Label>(SearchCriteria.ByAutomationId(constAutoID));

        }





    }
}
