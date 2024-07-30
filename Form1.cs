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
using System.Net.Http;
using System.Threading.Tasks;

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

        private string FormatOptions()
        {
            string options = OptionA.Text + " || ";

            if (OptionB.Text != "")
            {
                options += OptionB.Text + " || ";
            }

            if (OptionC.Text != "")
            {
                options += OptionC.Text + " || ";
            }

            if (OptionD.Text != "")
            {
                options += OptionD.Text;
            }

            return options;
        }

        private void FormatRespone(string responseBody)
        {
            Response response = JsonConvert.DeserializeObject<Response>(responseBody);

            TxtPrediction.Text = response.choice;
            memoEdit2.Text = response.explanation;
        }

        private async Task LoadData()
        {
            string url = "http://localhost:8000/qna/ask";

            Request re = new Request(memoEdit1.Text, FormatOptions());

            string jsonData = JsonConvert.SerializeObject(re);

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(url, content);

                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    var jsonResult = JsonConvert.DeserializeObject(responseBody).ToString();

                    FormatRespone(jsonResult);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            memoEdit1.Text = memoEdit2.Text = OptionA.Text = OptionB.Text = OptionC.Text = OptionD.Text = "";
            TxtAnswer.Text = "#";
            TxtPrediction.Text = "#";

            labelControl1.BackColor = Color.Transparent;
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);

            try
            {                
                await LoadData();

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
            memoEdit2.Text = "";
            
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

        private void hyperlinkLabelControl2_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link);
        }

        private void hyperlinkLabelControl1_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link);
        }
    }
}
