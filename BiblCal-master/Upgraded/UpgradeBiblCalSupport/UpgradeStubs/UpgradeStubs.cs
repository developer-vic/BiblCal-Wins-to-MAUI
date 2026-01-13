
namespace UpgradeStubs
{
	public class AxMSComDlg_AxCommonDialog
		: System.Windows.Forms.Control
	{

		public void setFlags(int FLAGS)
		{
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("MSComDlg.CommonDialog.FLAGS");
		}
	} 
	public class MSComDlg_ColorConstants
	{

		public static UpgradeStubs.MSComDlg_ColorConstantsEnum getcdlCCRGBInit()
		{
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("MSComDlg.ColorConstants.cdlCCRGBInit");
			return (UpgradeStubs.MSComDlg_ColorConstantsEnum) MSComDlg_ColorConstantsEnum.cdlCCRGBInit;
		}
	} 
	public enum MSComDlg_ColorConstantsEnum
	{
		cdlCCRGBInit = 1
	}
}