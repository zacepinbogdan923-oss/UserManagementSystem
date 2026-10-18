using System.Collections.Generic;
namespace UserManagementSystem
{
    public class UserManager
    {
        private List<string> _users = new List<string>(); private int _count = 0;
        public void AddUser(string username)
        {
            _users.Add(username);
        }

        public bool RemoveUser(string username)
        {
            return _users.Remove(username);
        }
    }
}