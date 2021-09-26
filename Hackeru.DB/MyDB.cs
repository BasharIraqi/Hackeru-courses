using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackeru.DB
{
   public class MyDB
   {
       static List<Student> Students =new List<Student>();
       //static string[] Courses = { ".Net Basic", "OOP", "Core", "CCS", "HTML" };


        public static void Add(Student student)
        {
            Students.Add(student);
        }
        public static bool Remove(Student student)
        {
           bool isRemove;
           isRemove= Students.Remove(student);
           return isRemove;
        }

        public static Student ShowByLastName(string lastName)
        {
            foreach (var item in Students)
            {
                if (item.LastName == lastName)
                    return item;
            }
            return null;
        }
        public static void Save(Student student)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Id == student.Id)
                    Students[i] = student;
            }
            
        } 

       

    }

    
}
