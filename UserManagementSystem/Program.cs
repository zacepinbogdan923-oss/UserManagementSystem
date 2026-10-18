using System;

namespace UserManagementSystem;

internal class Program
{
    private static void Main()
    {
        var manager = new UserManager();

        Console.WriteLine("=== User Management System ===");

        manager.AddUser("alice");
        manager.AddUser("bob");

        Console.WriteLine("Пользователи после добавления:");
        foreach (string user in manager.GetUsers())
        {
            Console.WriteLine($"- {user}");
        }

        bool removed = manager.RemoveUser("alice");
        Console.WriteLine($"Удаление пользователя alice: {removed}");

        Console.WriteLine("Пользователи после удаления:");
        foreach (string user in manager.GetUsers())
        {
            Console.WriteLine($"- {user}");
        }

        Console.WriteLine($"Попытка удалить отсутствующего пользователя: {manager.RemoveUser("unknown")}");
    }
}
