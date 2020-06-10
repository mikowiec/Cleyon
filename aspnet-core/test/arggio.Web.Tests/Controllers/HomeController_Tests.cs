﻿using System.Threading.Tasks;
using arggio.Models.TokenAuth;
using arggio.Web.Controllers;
using Shouldly;
using Xunit;

namespace arggio.Web.Tests.Controllers
{
    public class HomeController_Tests: arggioWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}