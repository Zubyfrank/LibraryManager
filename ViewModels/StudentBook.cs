﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.Models;

namespace LibraryManager.Models
{
    public partial class StudentBook
    {

        //public string FullName
        //{ get
        //    {
        //        return Student.LastName+ " " + Student.FirstName + " "+ Student.MiddleName;
        //    }

        //}
        public  IList<Book> Bookss { get; set; }
        public IList<Student> Studentss { get; set; }
    }
}
