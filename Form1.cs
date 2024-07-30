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
using DevExpress.XtraEditors.TextEditController.Win32;
using System.IO;
using Newtonsoft.Json;

namespace EMSDesktop
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private RootObject RootObject;
        private int num = 0;
        private string[] answers = { "A", "B", "C", "D" };

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            Random random = new Random();

            int index = random.Next(num);
            TxtPrediction.Text = answers[index];

            Thread.Sleep(3000);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            memoEdit1.Text = OptionA.Text = OptionB.Text = OptionC.Text = OptionD.Text = "";
            TxtAnswer.Text = "#";
            TxtPrediction.Text = "#";

            labelControl1.BackColor = Color.Transparent;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);

            try
            {                
                LoadData();

                if (TxtPrediction.Text == TxtAnswer.Text)
                {
                    labelControl1.BackColor = Color.Green;
                }
                else
                {
                    labelControl1.BackColor = Color.Red;
                }
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            TxtPrediction.Text = "#";
            labelControl1.BackColor = Color.Transparent;
            
            Random random = new Random();

            int index = random.Next(RootObject.Data.Count);

            num = RootObject.Data[index].Choices.Length;

            memoEdit1.Text = RootObject.Data[index].Question;

            TxtAnswer.Text = RootObject.Data[index].Answer[0].ToString();

            try
            {
                OptionA.Text = RootObject.Data[index].Choices[0];
                OptionB.Text = RootObject.Data[index].Choices[1];
                OptionC.Text = RootObject.Data[index].Choices[2];
                OptionD.Text = RootObject.Data[index].Choices[3];
            }
            catch (Exception)
            {
                OptionD.Text = "";
                Console.WriteLine("Error: " + RootObject.Data[index].Question);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = @"D:\Project\EMS Desktop\EMSDesktop\EMSDesktop\datasets\test_01.json";

            string json = File.ReadAllText(filePath);

            RootObject = JsonConvert.DeserializeObject<RootObject>(json);
        }
    }
}
