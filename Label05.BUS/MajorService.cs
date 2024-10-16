using Label05.DAL.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Label05.BUS
{
    public class MajorService
    {
        public List<Major> GetAllByFaculty(int facultyID)
        {
            StudentModelDB context = new StudentModelDB();
            return context.Majors.Where(p => p.FacultyID == facultyID).ToList();
        }
    }
}
