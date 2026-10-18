using System;

namespace UserManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new UserManager();
            manager.AddUser("test");
            Console.WriteLine(manager.RemoveUser("test")); // Должно вывести True
        }
    }
}