using System.Collections.Generic;

namespace demo_efcore.Models
{
   public class Student
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public virtual ICollection<Grade> Grades { get; }
      public StudentAddress StudentAddress { get; set; }
      // Error!
      // public int StudentAddressId { get; set; }
      public virtual ICollection<Registration> Registrations { get; }
      public Student()
      {
         Grades = new List<Grade>();
         Registrations = new List<Registration>();
         // var s = new Student();
         // if (s.Grades == null) {
         //    s.Grades = new List<Grade>();
         // }
         // s.Grades.Add(new Grade());
      }
   }

}