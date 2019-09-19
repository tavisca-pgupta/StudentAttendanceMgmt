using StudentAttendanceManagementApi.Models;
using System.Collections;
using System.Collections.Generic;

namespace StudentAttendanceManagementApi.Contracts
{
    interface IStudentService : IUser
    {
        IEnumerable<Attendance> ViewAttendance(int studentId,int month);
        bool ApplyLeave(int studentId, int noOfDays);
    }
}
