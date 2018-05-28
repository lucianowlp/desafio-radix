using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Radix.Gateway.Domain;
using Radix.Gateway.Domain.Repository;
using Radix.Gateway.WebApi.Controllers;
using System;
using Xunit;

namespace Radix.Gateway.WebApi.Tests
{
    public class LojistaControllerTests
    {
        [Fact]
        public void GetAllUserInTheRepository()
        {
            // Arrange
            var serviceMock = new Mock<IUserRepository>();
            serviceMock.Setup(x => x.FindByEmail("TESTE3@gmail.com")).Returns(() => new User
            {
                Id = new Guid(),
                Name = "Teste3",
                LastName = "Teste3",
                Address = "",
                Email = "TESTE3@gmail.com",
                AntiFraudSystem = false
            });
            var controller = new LojistaController(serviceMock.Object);

            // Act
            var result = controller.Get("TESTE3@gmail.com");

            // Assert
            var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
            var data = okResult.Value.Should().BeAssignableTo<object>().Subject;

            Assert.NotNull(data);
        }
    }
}
