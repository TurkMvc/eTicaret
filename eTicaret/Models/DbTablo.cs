using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eTicaret.Models
{
    public class DbTablo
    {
    }
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public Adress Adress { get; set; }
        public string Mail { get; set; }
        public Shopping Shopping { get; set; }
    }
    public class Adress
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public int AptNo { get; set; } 
        public int KapiNo { get; set; } 
    }

    public class Departments
    {
        public int ID { get; set; }
        public string DeparmentsName { get; set; }
    }

    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public Departments Deparments { get; set; }
        public int Stock { get; set; }
        public byte[] ProductImage { get; set; }
        public int Price { get; set; }
       
    }
    public class Shopping
    {
        public int ID { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public DateTime DateTime { get; set; }
        public int Quantity { get; set; }
        public Adress Adress { get; set; }
    }
}