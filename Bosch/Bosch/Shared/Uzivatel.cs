using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bosch.Shared
{
    public enum Roles { Admin, User, David}
    public class Uzivatel
    {
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Login { get; set; }
        public Roles Role { get; set; }


    }
}
