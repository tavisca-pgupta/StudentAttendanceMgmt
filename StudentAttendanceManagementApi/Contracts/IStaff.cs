using StudentAttendanceManagementApi.Models;
using System;
using System.Collections.Generic;

namespace StudentAttendanceManagementApi.Contracts
{
    interface IStaff : IUser
    {
        bool UpdateAttendance(int studentId, DateTime dateTime, int period);
        IEnumerable<IEnumerable<Attendance>> ViewAttendance(int studentId, int month, int subjectId);
        IEnumerable<IEnumerable<IEnumerable<Attendance>>> ViewAttendance(int classId, char section, int month, int subjectId);
    }
}
