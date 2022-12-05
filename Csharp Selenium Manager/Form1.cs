using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Windows.Forms;

namespace Csharp_Selenium_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleniumManager.DriverPath("chromedriver");

            ChromeDriver drv = new ChromeDriver();
            drv.Navigate().GoToUrl("https://www.ebubekirbastama.com");
        }
    }
}
