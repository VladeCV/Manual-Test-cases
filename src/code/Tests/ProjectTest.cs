
using ManualTestingProjectPLUS.code.Pages;
using ManualTestingProjectPLUS.code.Tests;

namespace ManualTestingProjectPLUS.code.Tests{
    
    [TestFixture]
    public class ProjectTest : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSite leftSite = new LeftSite();
        Management management = new Management();

        [Test, Order(1)]
        public void UpdateProjectIcon()
        {
            mainPage.loginButton.Click();
            loginSection.Login("cabreracam@hotmail.com", "789456123cvcf");
                
            leftSite.ClickProjectName("Project Icon");
            leftSite.subMenuIcon.Click();
            leftSite.bugIcon.Click();
            
            Assert.IsTrue(leftSite.iconUpdated.IsControlDisplayed(),"ICON WAS NOT UPDATED");
        }
        
        [Test, Order(2)]
        public void AddDueDateItem()
        {
            mainPage.loginButton.Click();
            loginSection.Login("cabreracam@hotmail.com", "789456123cvcf");
            leftSite.ClickProjectName("Due date project");
            management.ClickIconName("item with no due date");
            management.setDateBtn.Click();
            management.dateData.SetText("Jun 12, 10:30");
            management.saveDate.Click();
            Assert.IsTrue(management.newDate.IsControlDisplayed(),"Date added");
        }
    }
}