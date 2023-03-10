using Microsoft.AspNetCore.Mvc;
using SessionStateManagementForHighScalability.Controllers;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Controller_Index_Test()
        {
            var controller = new MainController();
            var result = controller.Index();

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Controller_RegisterNewUser_Test()
        {
            var controller = new MainController();
            var result = controller.RegisterNewUser();
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Controller_ReturnSession_Test()
        {
            var obj = new MainController();
            var result = obj.ReturnSession(1) as ViewResult;
            Assert.Equal("Dashboard", result.ViewName);
        }

        [Fact]
        public void Controller_ReturnViewdataSession_Test()
        {
            var obj = new MainController();
            var result = obj.ReturnViewdataSession(2) as ViewResult;
            Assert.Equal("UserLoggedOut", result.ViewData["name"]);
        }


    }
}