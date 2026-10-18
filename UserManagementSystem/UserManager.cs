using System;
using System.Collections.Generic;

namespace UserManagementSystem;

public class UserManager
{
    private readonly List<string> _users = new();

    public void AddUser(string username)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            throw new ArgumentException("Имя пользователя не может быть пустым.", nameof(username));
        }

        _users.Add(username);
    }

    public bool RemoveUser(string username)
    {
        return _users.Remove(username);
    }

    public bool UserExists(string username)
    {
        return _users.Contains(username);
    }

    public IReadOnlyList<string> GetUsers()
    {
        return _users.AsReadOnly();
    }
}
