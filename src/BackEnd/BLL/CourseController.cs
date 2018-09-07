using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using BackEnd.Entities;
using BackEnd.DAL;
using System.Data.Entity;

namespace BackEnd.BLL
{
    [DataObject]
    public class CourseController
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Course> ListAllCourses()
        {
            using (var context = new MyDatabaseContext())
            {
                return context.Courses.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void AddCourse(Course data)
        {
            using (var context = new MyDatabaseContext())
            {
                context.Courses.Add(data);
                context.SaveChanges();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void UpdateCourse(Course info)
        {
            using (var context = new MyDatabaseContext())
            {
                context.Entry(info).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void RemoveCourse(Course course)
        {
            using (var context = new MyDatabaseContext())
            {
                context.Courses.Remove(context.Courses.Find(course.CourseId));
                context.SaveChanges();
            }
        }
    }
}
