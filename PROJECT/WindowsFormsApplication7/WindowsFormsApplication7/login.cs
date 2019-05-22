using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WindowsFormsApplication7
{
    [Table(Name = "login")]
    class login
    {
        string username;
        [Column(Name = "user name", IsPrimaryKey = true)]
        public string _username
        {
            get { return username; }
            set { username = value; }
        }
        int password;
        [Column(Name = "password")]
        public int _password
        {
            get { return password; }
            set { password = value; }
        }
        string answer;
        [Column(Name="answer")]
        public string _answer
        {
            get { return answer; }
            set { answer = value; }
        }
    }
}