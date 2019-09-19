using Microsoft.EntityFrameworkCore;
using StudentAttendanceManagementApi.Contracts;
using StudentAttendanceManagementApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAttendanceManagementApi.Services
{
    public class SubjectService : ISubjectService
    {
        private DatabaseContext _context = DatabaseContext.GetInstance();

        public bool AddSubject(string subjectName)
        {
            throw new NotImplementedException();
        }

        public string GetSubjectNameById(int subjectId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subject> GetSubjects()
        {
            return _context.Subjects.ToList();
        }

        public bool RemoveSubject(int subjectId)
        {
            throw new NotImplementedException();
        }
    }
}
