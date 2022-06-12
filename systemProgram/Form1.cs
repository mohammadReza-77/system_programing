using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemProgram
{
    public partial class Form1 : Form
    {

        [DllImport("User32.dll")]
        private static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
        public Form1()
        {
            InitializeComponent();
            int IDOK = 6;
            int IDNO = 7;
            int IDError = 0;
            uint MB_RIGHT = 0x00080000;
            uint MB_ICONINFORMATION = 0x00000040;
            uint MB_RTLREADING = 0x00100000;
            uint MB_YESNO = 0x00000004;
            uint uType = MB_RIGHT + MB_ICONINFORMATION + MB_RTLREADING + MB_YESNO;
            int Return_Value = MessageBox(this.Handle, ". انتخاب", "لطفا يک دکمه را انتخاب کنيد ", uType);

            if (Return_Value == IDError)
            {
                MessageBox(this.Handle, ". جواب", "اجرا با خطا روبه رو شده است ", uType);
            }
            else if (Return_Value == IDOK)
            {
                MessageBox(this.Handle, "جواب", " دکمه آری کلیک شده ", uType);
            }
            else if (Return_Value == IDNO)
            {
                MessageBox(this.Handle, " جواب", "دکمه خير کليک شده ", uType);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
