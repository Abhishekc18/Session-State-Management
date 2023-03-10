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
        public void TestMVC()
        {
            var obj = new MainController();
            var result = obj.ReturnStudent(1) as ViewResult;
            Assert.Equal("bsc", result.ViewName);
        }


    }
}