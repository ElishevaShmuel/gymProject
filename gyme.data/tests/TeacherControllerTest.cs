﻿
using gym.API.Controllers;
using IdataContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym.data.tests
{
    public class TeacherControllerTest
    {

        private readonly TeacherController controllerTest;
        //public TeacherControllerTest()
        //{ controllerTest = new TeacherController(new FakeData()); }
        [Fact]
        void GetAll_ReturnTeachers()
        {
            //Arrange

            //Act
            var controller = controllerTest;
            var result = controller.Get();
            //Assert
            Assert.IsType<List<teather>>(result);
        }
        [Fact]
        void GetById_OkObjResult()
        {
            //Arrange
            var id = "1";
            //Act
            var controller = controllerTest;
            var result = controller.Get(id);
            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        void GetById_NotFoundResult()
        {
            //Arrange
            var id = "4";
            //Act
            var controller = controllerTest;
            var result = controller.Get(id);
            //Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }
        [Fact]
        void Post_OkAddResult()
        {
            //Arrange
            var c = new teather();

            //Act
            var controller = controllerTest;
            var result = controller.Post(c);

            //Assert
            Assert.IsType<OkResult>(result);

        }
        [Fact]
        void put_OkPutResult()
        {
            var id = "1";
            var name = "";
            //Act
            var controller = controllerTest;
            var result = controller.Put(id, name);
            //Assert
            Assert.IsType<OkResult>(result);
        }
        [Fact]
        void put_NotFoundPutResult()
        {
            var id = "4";
            var t = "";
            //Act
            var controller = controllerTest;
            var result = controller.Put(id, t);
            //Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }
        [Fact]
        void Delete_OkResult()
        {
            var id = "1";
            //Act
            var controller = controllerTest;
            var result = controller.Delete(id);
            //Assert
            Assert.IsType<OkResult>(result);
        }
        [Fact]
        void Delete_NotFoundResult()
        {
            var id = "4";
            //Act
            var controller = controllerTest;
            var result = controller.Delete(id);
            //Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }
    }
}
