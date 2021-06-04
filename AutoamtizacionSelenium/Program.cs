using System;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium;

namespace AutoamtizacionSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new OperaDriver();
            driver.Url = "https://docs.microsoft.com/en-us/azure/devops/organizations/accounts/use-personal-access-tokens-to-authenticate?view=azure-devops&tabs=preview-page";
            driver.Manage().Window.FullScreen();


            //driver.Manage().Window.Minimize();
        }
    }
}
