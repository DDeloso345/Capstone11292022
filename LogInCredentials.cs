using System;

namespace Capstone
{
    public class LogInCredentials
    {
        public String username { get; set; }
        public String password { get; set; }
        public String HierarchyLvl { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{username} {password} ({HierarchyLvl})";
            }
        }
    }
}
