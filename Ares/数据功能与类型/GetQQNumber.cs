using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;

namespace Ares
{
    class GetQQNumber
    {
        #region 引用API函数声明
        public delegate bool WndEnumProc(int hWnd, int lParam);

        /// <summary>
        /// 遍历Windows所有窗口并返回窗口句柄集合
        /// </summary>
        [DllImport("user32.dll")]
        public static extern int EnumWindows(WndEnumProc lpEnumFunc, int lParam);

        /// <summary>
        /// 根据窗口句柄获取窗口的类名
        /// </summary>
        [DllImport("user32.dll")]
        public static extern int GetClassName(int hWnd, StringBuilder lpString, int nMaxCount);

        /// <summary>
        /// 根据窗口句柄获取窗口的标题
        /// </summary>
        [DllImport("user32.dll")]
        public static extern int GetWindowText(int hwnd, StringBuilder lptrString, int nMaxCount);
        #endregion

        #region 根据窗口标题查找窗口句柄
        /// <summary>
        /// 根据窗口标题模糊匹配符合的窗口并返回窗口句柄集合，若无符合的则返回空集合
        /// </summary>
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
                Console.WriteLine("你是我的关键词");
            }
        }

        /// <summary>
        /// 根据窗口标题精确匹配符合的窗口并返回窗口句柄集合，若无符合的则返回空集合
        /// </summary>
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
        #endregion

        #region 获取用户QQ号
        /// <summary>
        /// 获取已登录的QQ客户端的QQ号，若存在则返回QQ号字符串集合，不存在则返回空集合
        /// </summary>
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
                    numberList.Add(lptrString.ToString().Replace("qqexchangewnd_shortcut_prefix_", string.Empty));
                }
                return numberList;
            }
            else
                return numberList;
        }

        /// <summary>
        /// 获取当前电脑上登录过的QQ的QQ号，若存在则返回QQ号字符串集合，不存在则返回空集合
        /// </summary>
        public static List<string> GetLocalQQ()
        {
            List<string> result = new List<string>();
            try
            { 
                DirectoryInfo dirInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Tencent Files");
                DirectoryInfo[] dirSub = dirInfo.GetDirectories();
                if (dirSub.Length > 0)
                {
                    foreach (DirectoryInfo d in dirSub)
                    {
                        result.Add(d.Name);
                    }
                    result.Remove("All Users");//最后要删去All Users这个无用文件夹
                    return result;
                }
                else
                    return result;
            }
            catch
            {
                return result;
            }
        }
        #endregion
    }
}
