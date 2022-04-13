using System.Collections.Generic;

namespace KonusarakOgrenCase.Models
{
    public class RoleModels
    {
        public static string Admin = "Admin";
        public static string User = "User";

        public static ICollection<string> Roles => new List<string>() { Admin, User};
    }
}
