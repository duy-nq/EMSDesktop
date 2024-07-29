using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using DevExpress.XtraSplashScreen;

namespace EMSDesktop
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            Thread.Sleep(3000);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            memoEdit1.Text = OptionA.Text = OptionB.Text = OptionC.Text = OptionD.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);

            try
            {
                LoadData();
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
