using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IWebDriver driver;
        public Form1()
        {
            InitializeComponent();
            this.Load += OpenWebsite;
        }

        private void OpenWebsite(object sender, EventArgs e)
        {
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-logging");
            // IMPORTANT! Must add path to own chrome driver location!
            driver = new ChromeDriver(@"C:\Users\rkime\OneDrive\Dators\", options);
            driver.Url = "https://ebay.com";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;

            var searchBox = driver.FindElement(By.Id("gh-ac"));
            var searchBtn = driver.FindElement(By.Id("gh-search-btn"));

            searchBox.Clear();
            searchBox.SendKeys(searchText);
            searchBtn.Click();

            string resultUrl = driver.Url;
            textBox2.Text = resultUrl;

            richTextBox1.AppendText(resultUrl + Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            driver.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back();
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
