using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HyperDevCase.Models;

namespace Values.Controllers
{
    public class DBCase
    {
        private readonly CaseContext _context;

        public DBCase(CaseContext context)
        {
            _context = context;
        }


        public List<Department> Control(int departmentid)
        {
            var caseContext = _context.Department.Where(b => b.Departmentid == departmentid).Include(b => b.Company);
            return caseContext.ToList();
        }

        public bool DeleteDepartment(int id)
        {
            var department = _context.Department.Find(id);
            if (department == null)
            {
                return false;
            }
            try
            {
                _context.Department.Remove(department);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
