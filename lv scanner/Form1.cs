using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace lv_scanner
{
    public partial class Form1 : Form
    {
        IntPtr context;
        public Form1()
        {
            InitializeComponent();
            context = IntPtr.Zero;
        }

        private void buttonTryHook_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int res;
            StringBuilder error = new StringBuilder(256);
            res = LibWrapper.CreateContext(textBoxWindowTitle.Text, string.Empty, textBoxListViewCls.Text, out context);
            if(res!= 0)
            {
                LibWrapper.GetError(context,  error);
                textBox1.Text += "Error CreateContext\r\n";
                textBox1.Text += error + "\r\n";
                return;
            }
            res = LibWrapper.Read(context);
            if(res!= 0)
            {
                textBox1.Text += "Error Read\r\n";
                return;
            }
            int rowCount = LibWrapper.GetRowCount(context);
            int colCount = LibWrapper.GetColumnCount(context);

            for(int row = 0; row < rowCount; row++)
            {

                for( int col = 0; col < colCount ; col++)
                {
                    StringBuilder sb = new StringBuilder(256);
                    res = LibWrapper.GetStringAt(context, row, col, sb);
                    if (res != 0)
                        break;
                    textBox1.Text += sb + "\t";
                }
                textBox1.Text += "\r\n";
            } 
        }
    }

    public static class LibWrapper
    {
        [DllImport("listview hook.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateContext(
            [MarshalAs(UnmanagedType.LPWStr)] String title,
            [MarshalAs(UnmanagedType.LPWStr)] String exeName,
            [MarshalAs(UnmanagedType.LPWStr)] String lvCls,
            out IntPtr context
            );
        [DllImport("listview hook.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Read(IntPtr context);
        [DllImport("listview hook.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetColumnCount(IntPtr context);
        [DllImport("listview hook.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetRowCount(IntPtr context);
        [DllImport("listview hook.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetStringAt(
            IntPtr context,
            int row,
            int col,
            [MarshalAs(UnmanagedType.LPWStr, SizeConst = 256)]  StringBuilder str,
            int maxSize = 256
            );
        [DllImport("listview hook.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetError(
            IntPtr context,
            [MarshalAs(UnmanagedType.LPWStr, SizeConst = 256)] StringBuilder str,
            int size = 256
            );
    }
}
