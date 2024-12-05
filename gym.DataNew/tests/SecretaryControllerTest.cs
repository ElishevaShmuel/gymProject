using gym.API.Controllers;
using IdataContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.DataNew.tests
{
    public class SecretaryControllerTest
    {
        private readonly SecretaryController controllerTest;
        //public SecretaryControllerTest()
        //{ controllerTest = new SecretaryController(new FakeData()); }
        [Fact]
        void Get_SecResult()
        {
            //Arrange

            //Act
            var controller = controllerTest;
            var result = controller.Get();
            //Assert
            Assert.IsType<secretary>(result);
        }
        [Fact]
        void Post_OkResult()
        {
            //Arrange
            var sec = new secretary();
            //Act
            var controller = controllerTest;
            var result = controller.Post(sec);
            //Assert
            Assert.IsType<OkResult>(result);
        }
        [Fact]
        void Put_OkResult()
        {
            //Arrange
            var c = "";

            //Act
            var controller = controllerTest;
            var result = controller.Put(c);

            //Assert
            Assert.IsType<OkResult>(result);

        }
        [Fact]
        void Delete_OkResult()
        {

            //Act
            var controller = controllerTest;
            var result = controller.Delete();
            //Assert
            Assert.IsType<OkResult>(result);
        }

    }
}
