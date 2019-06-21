using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ShopManagement
{
   [Table(Name= "Supplier")]
    class supplier
    {
        int ID;
       [Column(Name= "Sup_ID",IsPrimaryKey=true)]
        public int _ID 
        {
            get {return ID ;}
            set {ID= value ;}
        }
        string name;
       [Column(Name = "Sup_Name")]
        public string _name 
        {
            get { return name; }
            set {name= value ;}
        }
        int age;
       [Column(Name = "Sup_Age")]
        public int _age 
        {
            get {return age ;}
            set {age= value ;}
        }
        string address;
       [Column(Name = "Sup_Address")]
        public string _address 
        {
            get {return address ;}
            set {address= value ;}
        }
        string contact;
       [Column(Name = "Sup_Contact")]
        public string _contact 
        {
            get {return contact ;}
            set {contact=value ;}
        }

    }
}
