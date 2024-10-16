using Label05.DAL.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Label05.BUS
{
    public class FacultyService
    {
        public List<Faculty> GetAll()
        {
            StudentModelDB context = new StudentModelDB();
            return context.Faculties.ToList();
        }
    }
}
