using System.Runtime.InteropServices;

namespace UpgradeBiblCalSupport.PInvoke.SafeNative
{
	public static class user32
	{

		public static int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags)
		{
			return UpgradeBiblCalSupport.PInvoke.UnsafeNative.user32.SetWindowPos(hwnd, hWndInsertAfter, x, y, cx, cy, wFlags);
		}
	}
}