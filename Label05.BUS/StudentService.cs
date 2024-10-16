using Label05.DAL.Enitities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Label05.BUS
{
    public class StudentService
    {
        public List<Student> GetAll()
        {
            StudentModelDB context = new StudentModelDB();
            return context.Students.ToList();
        }
        public List<Student> GetAllHasNoMajor()
        {
            StudentModelDB context = new StudentModelDB();
            return context.Students.Where(p=>p.MajorID == null).ToList(); 
        }
        public List <Student> GetAllHasNoMajor(int facultyID) 
        {
            StudentModelDB context = new StudentModelDB();
            return context.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
        }
        public Student FindByID(string studentID)
        {
            StudentModelDB context = new StudentModelDB();
            return context.Students.FirstOrDefault(p => p.StudentID == studentID); 
        }
        public void InsertUpdate(Student s)
        {
            StudentModelDB context = new StudentModelDB();
            context.Students.AddOrUpdate(s);
            context.SaveChanges();
        }

        public void Delete(string mssv)
        {
            throw new NotImplementedException();
        }
    }
}
