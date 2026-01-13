using System.Reflection;
using System.Windows.Forms;

namespace UpgradeHelpers.Gui
{
    public static partial class TabControlHelper
    {
        public static int GetOldTab(this TabControl tabControl)
        {
            FieldInfo field = tabControl.GetType().GetField("lastSelection", BindingFlags.NonPublic | BindingFlags.Instance);
            return (int)field.GetValue(tabControl);
        }
        /// <summary>
        /// Method that simulates the indexer of the TabControl
        /// </summary>
        /// <param name="tabControl"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static TabPage TabPages(this TabControl tabControl, object key)
        {
            if (key != null && key is string)
                {
                    string keyLocal = System.Convert.ToString(key);
                    return tabControl.TabPages[tabControl.TabPages.ContainsKey(keyLocal) ? keyLocal : "tab" + keyLocal];
                }
                else
                    return tabControl.TabPages[System.Convert.ToInt32(key)];
        }

        public static void SelectTab(this TabPage tab)
        {
            (tab.Parent as TabControl).SelectedTab = tab;
        }

        #region Enums TabControl
        /// <summary>
        ///     Use bottom left corner pixel of image
        /// </summary>
        public enum Constants_MaskColorSource
        {
            //
            // Summary:
            //     No mask color (non-transparent)
            ssMaskColorNone = 0,
            //
            // Summary:
            //      Use bottom left corner pixel of image
            ssMaskColorUseImage = 1
        }

        /// <summary>
        ///    Constants that specify the style of the Tab control
        /// </summary>
        public enum Constants_TabStyle
        {
            //
            // Summary:
            //      Note Page
            ssStyleNotePage = 1,
            //
            // Summary:
            //      Note Page Flat(no borders)
            ssStyleNotePageFlat = 2,

            //
            // Summary:
            //       Property Page
            ssStylePropertyPage = 0,


            //
            // Summary:
            //      Wizard (no runtime UI)
            ssStyleWizard = 3

        }

        /// <summary>
        ///    Constants that specify which tab to select
        /// </summary>
        public enum Constants_SelectedTab
        {
            //
            // Summary:
            //     Select first visible(and enabled) tab
            ssSelectFirstTab = -3,
            //
            // Summary:
            //      Select last visible(and enabled) tab
            ssSelectLastTab = -4,

            //
            // Summary:
            //       Select next visible(and enabled) tab
            ssSelectNextTab = -1,

            //
            // Summary:
            //      Select previous visible(and enabled) tab
            ssSelectPreviousTab = -2
        }
        #endregion
    }
}
