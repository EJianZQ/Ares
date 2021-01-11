using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Net;

namespace Ares
{
    class GetQQNumber
    {
        public  delegate bool WndEnumProc(int hWnd, int lParam);

        //遍历所有窗口
        [DllImport("user32.dll")]
        public static extern int EnumWindows(WndEnumProc lpEnumFunc, int lParam);

        // 获取窗口的类名
        [DllImport("user32.dll")]
        public static extern int GetClassName(int hWnd, StringBuilder lpString, int nMaxCount);

        // 获取窗口的标题
        [DllImport("user32.dll")]
        public static extern int GetWindowText(int hwnd, StringBuilder lptrString, int nMaxCount);


        public static IReadOnlyList<int> FindWindowKeyText(string keyWords)
        {
            var lptrString = new StringBuilder(512);
            var windowList = new List<int>();
            EnumWindows(OnWindowEnum, 0);
            return windowList;

            bool OnWindowEnum(int hwnd, int lparam)
            {
                // 进行关键词过滤
                GetWindowText(hwnd, lptrString, lptrString.Capacity);
                if(lptrString.ToString().Contains(keyWords))
                    windowList.Add(hwnd);
                return true;
            }
        }

        public static IReadOnlyList<int> FindWindowFullText(string WindowTextName)
        {
            var windowList = new List<int>();
            EnumWindows(OnWindowEnum, 0);
            return windowList;

            bool OnWindowEnum(int hwnd, int lparam)
            {
                var lpString = new StringBuilder(512);
                GetWindowText(hwnd, lpString, lpString.Capacity);
                if (lpString.ToString().Equals(WindowTextName, StringComparison.InvariantCultureIgnoreCase))
                {
                    windowList.Add(hwnd);
                }
                return true;
            }
        }

        public static List<string> GetOnlineQQ()
        {
            List<string> numberList = new List<string>();
            IReadOnlyList<int> qqHwndList = FindWindowKeyText("qqexchangewnd_shortcut_prefix_");
            var lptrString = new StringBuilder(512);
            if (qqHwndList.Count > 0)
            {
                foreach (int temphwnd in qqHwndList)
                {
                    GetWindowText(temphwnd, lptrString, lptrString.Capacity);
                    numberList.Add(lptrString.ToString());
                }
                return numberList;
            }
            else
                return numberList;
        }
    }
}
