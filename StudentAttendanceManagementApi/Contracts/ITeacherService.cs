using System;

namespace StudentAttendanceManagementApi.Contracts
{
    interface ITeacherService : IStaff
    {
        void MarkAttendance(int studentId, int classId, char section, int period, bool HasAttended, DateTime dateTime, int subjectId);
    }
}
