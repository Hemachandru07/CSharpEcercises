using System;

namespace Tutlane
{
    class User
    {
        private string name;
        private string location;
        public User(string a, string b)
        {
            name = a;
            location = b;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Location
        {
            get
            {
                return location;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User("chandru", "chennai");
            Console.WriteLine("Name: " + u.Name);
            Console.WriteLine("Location: " + u.Location);
            
        }
    }
}