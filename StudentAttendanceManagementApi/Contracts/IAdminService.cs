using System;

namespace StudentAttendanceManagementApi.Contracts
{
    interface IAdminService : IStaff
    {
        bool AddStudent(string studentName, int classId, char sectionId);
        bool AddTeacher(string name);
    }
}
