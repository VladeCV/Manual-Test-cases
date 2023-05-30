using OpenQA.Selenium;
using ManualTestingProjectPLUS.code.Control;


namespace ManualTestingProjectPLUS.code.Pages
{
    public class LeftSite
    {
        public Button addNewProjectButton = new Button(By.XPath("//td[text()='Add New Project']"));
        public TextBox projectNameTxtBox = new TextBox(By.Id("NewProjNameInput"));
        public Button addButton = new Button(By.Id("NewProjNameButton"));

        public Button subMenuIcon = new Button(By.XPath("//div[contains(@style,'block')]/img"));
        public Button editButton = new Button(By.XPath("//ul[contains(@style,'block')]//a[text()='Edit']"));
        public TextBox projectNameEditTxtBox = new TextBox(By.XPath("//td/div/input[@id='ItemEditTextbox']"));
        public Button saveButton = new Button(By.XPath("//td/div/img[@id='ItemEditSubmit']"));

        public Button bugIcon = new Button(By.XPath("//*[@id='IconFrameOuter']/span[6]"));

        public Label iconUpdated =
            new Label(By.XPath("//div[@style='background: url(Images/icons/bug.png) no-repeat;']"));
        
        public Button deleteButton = new Button(By.Id("ProjShareMenuDel"));
        public Boolean ProjectNameIsDisplayed(String nameValue) 
        {
            Label nameProject = new Label(By.XPath("(//ul[@id=\"mainProjectList\"]/li//td[text()='"+ nameValue + "'])[last()]"));
            return nameProject.IsControlDisplayed();
        }

        public void ClickProjectName(String nameValue)
        {
            Label nameProject = new Label(By.XPath("(//ul[@id=\"mainProjectList\"]/li//td[text()='" + nameValue + "'])[last()]"));
            nameProject.Click();
            
        }

    }
}
