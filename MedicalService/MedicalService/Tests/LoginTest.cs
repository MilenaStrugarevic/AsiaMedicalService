using MedicalService.Driver;
using MedicalService.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalService.Tests
{
    internal class LoginTest
    {
        LoginPage loginPage;
        string Message = "Login failed! Please ensure the username and password are valid.";

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
        }

        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }
        [Test]
        public void TC01_InvalidUserName()
        {
            loginPage.AppMedic.Click();
            loginPage.Login("Milena","ThisIsNotAPassword");
            Assert.That(Message, Is.EqualTo(loginPage.UserNoLogin.Text));
        }
        [Test]
        public void TC02_EnteringInvalidPasword_ShouldNotBeLoginOnPage()
        {
            loginPage.AppMedic.Click();
            loginPage.Login("John Doe", "WrongPassword");
            Assert.That(Message, Is.EqualTo(loginPage.UserNoLogin.Text));
        }
        [Test]
        public void TC03_EnterNoData_ShouldNotBeLoginOnPage()
        {
            loginPage.AppMedic.Click();
            loginPage.Login("", "");
            Assert.That(Message, Is.EqualTo(loginPage.UserNoLogin.Text));
        }
    }
}
