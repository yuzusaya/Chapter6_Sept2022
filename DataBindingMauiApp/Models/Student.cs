using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingMauiApp.Models
{
    public class Student
    {
        //public int Id { get; set; }
        private int _id;
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }//Active,Inactive

    }
}
