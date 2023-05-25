using NUnit.Framework;
using WMay2023.Pages;
using WMay2023.Utilities;

namespace WMay2023.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Notification_Tests : CommonDriver
    {
        [Test, Order(1)]
        public void CreateNotification_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObject = new HomePage();
            homePageObject.GoToNotificationPage(driver);

            // Notification page object initialization and definition
            NotificationPage notificationPageObject = new NotificationPage();
            notificationPageObject.CreateNotification(driver);
        }

        [Test, Order(2)]
        public void EditNotification_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObject = new HomePage();
            homePageObject.GoToNotificationPage(driver);

            // Edit notification
            NotificationPage notificationPageObject = new NotificationPage();
            notificationPageObject.EditNotification(driver);
        }

        [Test, Order(3)]
        public void DeleteNotification_Test()
        {
            // Home page object initialization and definition
            HomePage homePageObject = new HomePage();
            homePageObject.GoToNotificationPage(driver);

            // Delete notification
            NotificationPage notificationPageObject = new NotificationPage();
            notificationPageObject.DeleteNotification(driver);
        }
    }
}
