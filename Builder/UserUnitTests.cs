namespace Builder.UnitTests
{
    using System;
    using NUnit.Framework;

    class UserUnitTests
    {
        private User user;
        private UserBuilder userBuilder;
        
        // TODO: Quitar los try/catch y poner Assert.Throws()

        [SetUp]
        public void SetUp() 
        {
            user = new User();
            userBuilder = new UserBuilder();
        }

        [Test]
        public void User_NewUserComplete()
        {
            userBuilder.InitializeAll(user);

            Assert.AreEqual("Pepe", user.Username);
            Assert.AreEqual("***", user.Password);
            Assert.AreEqual(@"c\ Arriba 1", user.Street);
        }

        [Test]
        public void User_PhoneHasLowNumber()
        {
            userBuilder.InitializeRequired(user);

            try
            {
                userBuilder.SetPhone(user, 555);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void User_PhoneHasHighNumber()
        {
            userBuilder.InitializeRequired(user);

            try
            {
                userBuilder.SetPhone(user, 1234567890);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void User_CPHasLowNumber()
        {
            userBuilder.InitializeRequired(user);

            try
            {
                userBuilder.SetCP(user, 1);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void User_CPHasHighNumber()
        {
            userBuilder.InitializeRequired(user);

            try
            {
                userBuilder.SetCP(user, 1234567890);
            }

            catch (ArgumentException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void User_IsNotAdmin()
        {
            userBuilder.InitializeRequired(user);

            // Aqui irian más pruebas para ver que tener Admin=false restringe permisos
            Assert.AreEqual(false, user.IsAdmin);
        }

        [Test]
        public void User_IsAdmin()
        {
            userBuilder.InitializeRequired(user);
            userBuilder.IsAdmin(user);

            // Aqui irian más pruebas para ver que tener Admin=true concede permisos
            Assert.AreEqual(true, user.IsAdmin);
        }

        [Test]
        public void User_NotReturnNull()
        {
            Assert.NotNull(user);
        }
    }
}
