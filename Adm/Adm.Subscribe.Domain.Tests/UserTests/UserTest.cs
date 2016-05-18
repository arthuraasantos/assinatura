using System;
using Adm.Subscribe.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adm.Subscribe.Domain.Tests.UserTests
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void CreateNewUserWithoutParametersAndReturnANotNullUser()
        {
            var newUser = new User();
            Assert.IsNotNull(newUser);
        }

        public void CreateNewUserWithEmailAndPasswordAndReturnANotNullUser()
        {
            var newUser = new User("arthur@arthur.com.br","234");
            Assert.IsNotNull(newUser);
        }
    }
}
