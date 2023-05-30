using OpenQA.Selenium;

namespace ManualTestingProjectPLUS.code.Control
{
    public class TextBox : ControlSelenium
    {
        public TextBox(By locator) : base(locator)
        {
        }

        public void SetText(String value) 
        {
            FindControl();
            control.Clear();
            control.SendKeys(value);
        }

    }
}
