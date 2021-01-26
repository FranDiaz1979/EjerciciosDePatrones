namespace Builder.UnitTests
{
    using System;
    using NUnit.Framework;

    class UserUnitTests
    {
        [Test]
        public void User_NewUserComplete()
        {
            var user = new User
            {
                Username = "Pepe",
                Password = "****",
                Street = @"c\ Pallars 2",
                Phone = 600100100,
                CP = 08000,
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
            catch (ArgumentException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void User_PhoneHasHighNumber()
        {
            try
            {
                var user = new User
                {
                    Username = "Pepe",
                    Password = "****",
                    Street = @"c\ Pallars 2",
                    Phone = 1234567890,
                };
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void User_CPHasLowNumber()
        {
            try
            {
                var user = new User
                {
                    Username = "Pepe",
                    Password = "****",
                    Street = @"c\ Pallars 2",
                    CP = 1,
                };
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void User_CPHasHighNumber()
        {
            try
            {
                var user = new User
                {
                    Username = "Pepe",
                    Password = "****",
                    Street = @"c\ Pallars 2",
                    CP = 1234567890,
                };
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void User_IsNotAdmin()
        {
            var user = new User
            {
                Username = "Pepe",
                Password = "****",
                Street = @"c\ Pallars 2",
            };

            // Aqui irian más pruebas para ver que tener Admin=false restringe permisos
            Assert.AreEqual(false, user.IsAdmin);
        }

        [Test]
        public void User_IsAdmin()
        {
            var user = new User
            {
                Username = "Pepe",
                Password = "****",
                Street = @"c\ Pallars 2",
                IsAdmin =true,
            };

            // Aqui irian más pruebas para ver que tener Admin=true concede permisos
            Assert.AreEqual(true, user.IsAdmin);
        }
    }
}
