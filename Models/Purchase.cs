using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pic5.Models
{
    public class Purchase
    {
        public Purchase() { }
        public Purchase(int id, string item, double price, int departmentId)
        {
            Id = id;
            Item = item;
            Price = price;
            DepartmentId = departmentId;
        }

        public int Id { get; set; }
        public string Item { get; set; }
        public double Price { get; set; }
        public int DepartmentId { get; set; }
    }
}
