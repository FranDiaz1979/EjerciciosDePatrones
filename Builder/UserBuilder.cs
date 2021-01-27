namespace Builder
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UserBuilder
    {
        public void InitializeRequired(User user)
        {
            user.Username = "Pepe";
            user.Password = "***";
            user.Email = "pepe@gmail.com";
        }
        public void InitializeAll(User user)
        {
            user.Username = "Pepe";
            user.Password = "***";
            user.Email = "pepe@gmail.com";
            user.City = "Barcelona";
            user.CP = 08001;
            user.Phone = 600600600;
            user.Street = @"c\ Arriba 1";
            user.Name = "Jose";
            user.Surname = "Rodríguez";
        }

        public void IsAdmin(User user)
        {
            user.IsAdmin = true;
        }

        public void IsExecutive(User user)
        {
            // user.WebExecutiveAllowed = true;
            // user.GrantAccessToExecutiveDirectory = true;
            // etc.
        }

        public void SetPhone(User user, int phone)
        {
            user.Phone = phone;
        }

        public void SetCP(User user, int cp)
        {
            user.CP = cp;
        }
    }
}
