using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation3UserManagement
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public UserLevel Level { get; set; }
    }
    public class DisplayUser
    {
        public string Name { get; set; }

        public string UserName { get; set; }

        public UserLevel Level { get; set; }
    }
}
