using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace QuickPaster
{
    public partial class FrmMain : UIForm
    {

        #region Definitions
        private const int WM_DRAWCLIPBOARD = 0x308;
        private const int WM_CHANGECBCHAIN = 0x30D;

        private IntPtr mNextClipBoardViewerHWnd;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern bool ChangeClipboardChain(IntPtr HWnd, IntPtr HWndNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        #endregion

        #region 生成器
        public void NewViewer()
        {
            mNextClipBoardViewerHWnd = SetClipboardViewer(this.Handle);
        }
        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        // DECLARE GLOBALS //
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        //public static string oldWindow = "";
        //public static string currentWindow = "";

        #region 剪切信息处理
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    {
                        SendMessage(mNextClipBoardViewerHWnd, m.Msg, m.WParam.ToInt32(), m.LParam.ToInt32());

                        //显示剪贴板中的文本信息
                        if (Clipboard.ContainsText())
                        {
                            IntPtr activeWindow = GetForegroundWindow();
                            foreach (Process process in Process.GetProcesses())
                            {
                                try
                                {
                                    if (activeWindow == process.MainWindowHandle)
                                    {
                                        var content = Clipboard.GetText();
                                        var source = process.MainWindowTitle.Split('-').LastOrDefault();
                                        StringBuilder stringBuilder = new StringBuilder();
                                        stringBuilder.AppendLine(content);
                                        ucClipboard ucClipboard = new ucClipboard();
                                        ucClipboard.tpFromSoft.Text += "来源应用：" + source;
                                        ucClipboard.txtClipbordRecord.Text = stringBuilder.ToString();
                                        flpClipboardArea.Controls.Add(ucClipboard);
                                    }
                                }
                                catch (System.ComponentModel.Win32Exception ex)
                                {
                                    UIMessageBox.ShowError(String.Format("软件遇到未知错误，请复制下列错误信息发布Issue,错误代码如下：{0}",ex));
                                    return;
                                }
                            }
                        }
                        break;
                    }
            }
            base.WndProc(ref m);
        }
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text += "V" + System.Windows.Forms.Application.ProductVersion.ToString();
            //先清空已经有内容的剪切板
            Clipboard.Clear();
            flpClipboardArea.Clear();

            NewViewer();
        }
    }
}
