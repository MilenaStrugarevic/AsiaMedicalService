using MedicalService.Driver;
using OpenQA.Selenium;

namespace MedicalService.Page
{
    public class LoginPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement AppMedic => driver.FindElement(By.Id("btn-make-appointment"));

        public IWebElement UserName => driver.FindElement(By.Id("txt-username"));
        public IWebElement Password => driver.FindElement(By.Id("txt-password"));
        public IWebElement ButtonLogin => driver.FindElement(By.Id("btn-login"));
        public IWebElement UserNoLogin => driver.FindElement(By.CssSelector(".text-danger"));

        public void Login(string user, string pass)
        {
            UserName.SendKeys(user);
            Password.SendKeys(pass);
            ButtonLogin.Submit();
        }
    }
}
