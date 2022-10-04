using Pets.ADOApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets.ClassApp
{
    public class DBConnection
    {
        public static BDDBEntities Connection = new BDDBEntities();
    }
}
