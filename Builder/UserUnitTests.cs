namespace Builder.UnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using NUnit;
    using NUnit.Framework;

    class UserUnitTests
    {
        [Test]
        public void User_New()
        {
            var user = new User
            {
                Username = "Pepe",
                Password = "****",
                Street = @"c\ Pallars 2",
            };
            Assert.AreEqual("Pepe", user.Username);
            Assert.AreEqual("****", user.Password);
            Assert.AreEqual(@"c\ Pallars 2", user.Street);
        }

        [Test]
        public void User_PhoneHasLowNumber()
        {
            try
            {
                var user = new User
                {
                    Username = "Pepe",
                    Password = "****",
                    Street = @"c\ Pallars 2",
                    Phone = 555,
                };
            }
            catch (ArgumentException exception)
            {
                //Assert.
                throw;
            }
        }

        [Test]
        void User_PhoneHasHighNumber()
        {
        }

        [Test]
        void User_CPHasLowNumber()
        {
        }

        [Test]
        void User_CPHasHighNumber()
        {
        }

        [Test]
        void User_IsNotAdmin()
        {
            // Aqui irian más pruebas para ver que tener Admin=false restringe permisos
        }

        [Test]
        void User_IsAdmin()
        {
            // Aqui irian más pruebas para ver que tener Admin=true concede permisos
        }
    }
}
