using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.DAL;
using BackEnd.Entities;
using System.ComponentModel;

namespace BackEnd.BLL
{
    [DataObject]
    public class MyStudentController
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Student> ListAllStudents()
        {
            using (var context = new MyDatabaseContext())
            {
                return context.Students.ToList();
            }
        }
    }
}
