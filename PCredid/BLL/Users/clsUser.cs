using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Users
{
    public class clsUser
    {

            public int id { get; set; }
            public string name { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public clsAdress address { get; set; }
            public string phone { get; set; }
            public string website { get; set; }
            public clsCompany company { get; set; }
    }
}
