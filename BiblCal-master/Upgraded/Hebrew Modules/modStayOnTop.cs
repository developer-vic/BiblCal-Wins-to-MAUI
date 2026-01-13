using System;
using System.Runtime.InteropServices;

namespace BiblCal
{
	internal static class modStayOnTop
	{

		// http://support.microsoft.com/kb/184297
		// Allows control of windows ability to stay on top.
		public const int SWP_NOMOVE = 2;
		public const int SWP_NOSIZE = 1;
		static readonly public int FLAGS = SWP_NOMOVE | SWP_NOSIZE;
		public const int HWND_TOPMOST = -1;
		public const int HWND_NOTOPMOST = -2;

		//UPGRADE_NOTE: (2041) The following line was commented. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2041
		//[DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		//extern public static int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

		internal static int SetTopMostWindow(int hwnd, bool Topmost)
		{

			int result = 0;
			if (Topmost)
			{ //Make the window topmost
				return UpgradeBiblCalSupport.PInvoke.SafeNative.user32.SetWindowPos(hwnd, HWND_TOPMOST, 0, 0, 0, 0, FLAGS);
			}
			else
			{
				result = UpgradeBiblCalSupport.PInvoke.SafeNative.user32.SetWindowPos(hwnd, HWND_NOTOPMOST, 0, 0, 0, 0, FLAGS);
				return 0;
			}
			return result;
		}
	}
}