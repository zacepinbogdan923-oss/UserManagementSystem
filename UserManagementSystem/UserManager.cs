
using System.Collections.Generic;

public class UserManager
{
    private List<string> _users = new List<string>();

    public void AddUser(string username)
    {
        _users.Add(username);
    }
}
