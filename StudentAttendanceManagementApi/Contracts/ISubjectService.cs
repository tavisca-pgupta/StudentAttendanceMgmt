using StudentAttendanceManagementApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAttendanceManagementApi.Contracts
{
    public interface ISubjectService
    {
        bool AddSubject(string subjectName);
        bool RemoveSubject(int subjectId);
        string GetSubjectNameById(int subjectId);
        IEnumerable<Subject> GetSubjects();
    }
}
