using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace test
{
    public class Users
    {
        public string Name { get; set; }
        public int age { get; set; }

        public IEnumerable<Users> getUsers()
        {
            List<Users> list = new List<Users>()
        {
            new Users(){Name="demo1",age=23},

            new Users(){Name="demo2",age=24}
        };
            return list;
        }
    }
   
}
