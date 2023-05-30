using ManualTestingProjectPLUS.code.Control;
using OpenQA.Selenium;

namespace ManualTestingProjectPLUS.code.Pages;

public class Management
{
    public Label setDateBtn = new Label(By.XPath("//tbody//td[3]//div[text()='Set Due Date']"));
    public Label newDate = new Label(By.XPath("//tbody//div[text()='12 Jun 10:30 AM']"));
    public Button saveDate = new Button(By.XPath("//div[@id='EditDueDate11164215']//input[@id='LinkShowDueDateSave']"));
    public TextBox dateData =
        new TextBox(By.XPath("//div[@class='clear_button_wrapper']//input[@class='AddItemAdvDate2']"));
    public void ClickIconName(String nameValue)
    {
        Label nameItem = new Label(By.XPath("//tbody//div[text()='"+ nameValue +"']"));
        Session.Session.Instance().GetBrowser().Navigate();
    }
}