using StudentAttendanceManagementApi.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAttendanceManagementApi.Models;

namespace StudentAttendanceManagementApi.Services
{
    public class AdminService : IAdminService
    {
        public bool AddStudent(string studentName, int classId, char sectionId)
        {
            throw new NotImplementedException();
        }

        public bool AddTeacher(string name)
        {
            throw new NotImplementedException();
        }

        public bool ChangePassword(int userID, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public bool Login(int userID, string password)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAttendance(int studentId, DateTime dateTime, int period)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEnumerable<Attendance>> ViewAttendance(int studentId, int month, int subjectId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEnumerable<IEnumerable<Attendance>>> ViewAttendance(int classId, char section, int month, int subjectId)
        {
            throw new NotImplementedException();
        }
    }
}
