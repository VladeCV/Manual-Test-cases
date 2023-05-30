using OpenQA.Selenium;
using ManualTestingProjectPLUS.code.Session;

namespace ManualTestingProjectPLUS.code.Control
{
    public class ControlSelenium
    {
        protected By locator;
        protected IWebElement control;

        public ControlSelenium(By locator) 
        {
            this.locator = locator;
        }

        protected void FindControl() 
        {
            control = Session.Session.Instance().GetBrowser().FindElement(locator);
        }

        public void Click() 
        { 
            FindControl();
            control.Click();
        }

        public bool IsControlDisplayed()
        {
            try
            {
                FindControl();
                return control.Displayed;
            }catch (Exception ex)
            {
                return false;
            }
        }
    }
}
