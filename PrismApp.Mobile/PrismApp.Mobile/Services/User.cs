using System;

namespace PrismApp.Mobile.Services
{
    class User : IUser
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public User()
        {
            Name = "John Doe";
            Id = Guid.NewGuid().ToString();
        }
    }
}