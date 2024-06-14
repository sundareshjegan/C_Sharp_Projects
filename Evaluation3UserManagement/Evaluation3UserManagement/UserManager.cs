using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation3UserManagement
{
    public static class UserManager
    {
        public static List<User> Users = new List<User>()
        {
            new User()
            {
                Name = "admin",
                UserName = "admin",
                Password = "admin",
                Level = UserLevel.Admin
            }
        };

        public static User CurrentUser = Users[0];
        public static event EventHandler OnCurrentUserChanged;
        private static int id = 1;

        public static bool AddUser(User user)
        {
            user.UserId = id++;
            if (IsUserExists(user.UserName))
            {
                return false;
            }
            Users.Add(user);
            OnCurrentUserChanged?.Invoke(CurrentUser, EventArgs.Empty);
            return true;
        }

        public static void UpdateUser(User user)
        {
            CurrentUser.Name = user.Name;
            CurrentUser.Password = user.Password;
            CurrentUser.Level = user.Level;
        }

        public static void UpdateCurrentUser(string username)
        {
            CurrentUser = GetUserDetails(username);
            OnCurrentUserChanged?.Invoke(CurrentUser,EventArgs.Empty);
        }

        public static void DeleteUser(string userName)
        {
            foreach(User user in Users)
            {
                if(user.UserName == userName)
                {
                    Users.Remove(user);
                    break;
                }
            }
        }

        public static bool IsUserExists(string userName)
        {
            foreach(User user in Users)
            {
                if(user.UserName == userName)
                {
                    return true;
                }
            }
            return false;
        }

        public static User GetUserDetails(string userName)
        {
            foreach(User user in Users)
            {
                if(user.UserName == userName)
                {
                    return user;
                }
            }
            return null;
        }

        public static List<string> GetUserNamesBelowLevel(UserLevel level)
        {
            List<string> usernames = new List<string>();
            foreach(User user in Users)
            {
                if(user.Level > level)
                {
                    usernames.Add(user.UserName);
                }
            }
            return usernames;
        }

        public static List<DisplayUser> GetUserNameAndRoleBelowLevel(UserLevel level)
        {
            List<DisplayUser> usernames = new List<DisplayUser>();
            foreach (User user in Users)
            {
                if (user.Level > level)
                {
                    usernames.Add(new DisplayUser()
                    {
                        Name = user.Name,
                        UserName = user.UserName,
                        Level = user.Level
                    });
                }
            }
            return usernames;
        }

        public static UserLevel GetLevel(string level)
        {
            if(level.ToLower() == "administrator")
            {
                return UserLevel.Administrator;
            }
            else if (level.ToLower() == "admin")
            {
                return UserLevel.Admin;
            }
            else if(level.ToLower() == "manager")
            {
                return UserLevel.Manager;
            }
            else if(level.ToLower() == "supervisor")
            {
                return UserLevel.Supervisor;
            }
            return UserLevel.Operator;
        }
    }
}
