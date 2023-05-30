using OpenQA.Selenium;
using ManualTestingProjectPLUS.code.Control;

namespace ManualTestingProjectPLUS.code.Pages
{
    public  class MainPage
    {
        public Button loginButton = new Button(By.XPath("//img[@src=\"/Images/design/pagelogin.png\"]"));
    }
}
