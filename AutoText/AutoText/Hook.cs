using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoText
{
    class Hook
    {
        #region hook key board
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0002;

        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero; // id của mỗi element

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr keybd_event(byte vkCode, byte bScan, uint wParam, UIntPtr uIntPtr);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        /// <summary>
        /// Delegate a LowLevelKeyboardProc to use user32.dll
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// Set hook into all current process
        /// </summary>
        /// <param name="proc"></param>
        /// <returns></returns>
        /// 

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            {
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }

        /// <summary>
        /// Every time the OS call back pressed key. Catch them 
        /// then cal the CallNextHookEx to wait for the next key
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                CheckKey(vkCode);
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        public static void HookKeyboard()
        {
            _hookID = SetHook(_proc);
            Application.Run();
            UnhookWindowsHookEx(_hookID);
        }

        #endregion

        #region settext
        static string strValue = "";
        static string keyWord;
        static StreamReader reader;


        static void CheckKey(int vkCode)

        {
            Console.WriteLine("keyWord ngoai while" + keyWord);
            if (((Keys)(vkCode) == Keys.Space || (Keys)(vkCode) == Keys.Enter) && keyWord != null)
            {

                if (File.Exists("Data.txt"))
                {
                    reader = new StreamReader("Data.txt");
                }
                
                while (true)
                {
                    strValue = reader.ReadLine();
                    Console.WriteLine("strValue trong while" + strValue);
                    if (strValue == null)
                    {
                        reader.Close();
                        break;
                    }

                    string[] str = strValue.Split(':');

                    if (str[0].Equals(keyWord.ToLower()))
                    {

                        Thread.Sleep(50);

                        // xóa từ viết tắc
                        for (int i = 0; i < str[0].Length; i++)
                        {
                            keybd_event((byte)Keys.Back, 0, 0, UIntPtr.Zero);
                            keybd_event((byte)Keys.Back, 0, 2, UIntPtr.Zero);
                        }

                        // copy vào Clipboard
                        Clipboard.SetText(str[1]);
                        // shift+insert
                        // paste nội dung vào cửa sổ hiện tại đang làm việc, tại ví trị chuột hiện hành
                        keybd_event(0x10, 0, 0, UIntPtr.Zero);
                        keybd_event(0x2D, 0, 1, UIntPtr.Zero);
                        keybd_event(0x2D, 0, 2, UIntPtr.Zero);
                        keybd_event(0x10, 0, 2, UIntPtr.Zero);

                        Thread.Sleep(50);
                        Clipboard.Clear();
                        reader.Close();
                        break;
                    }
                }
                keyWord = "";
            }
            if (((char)vkCode >= 'A' && (char)vkCode <= 'Z') || ((char)vkCode >= 'a' && (char)vkCode <= 'z'))
            {
                keyWord += (char)(vkCode);
            }
            Console.WriteLine("keyWord duoi while " + keyWord);
            try
            {
                if (keyWord != null && (Keys)vkCode == Keys.Back)
                {
                    keyWord = keyWord.Remove(keyWord.Length - 1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        #endregion
    }
}
