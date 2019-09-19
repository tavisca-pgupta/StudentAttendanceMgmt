using System;

namespace StudentAttendanceManagementApi.Models
{
    public class Attendance
    {
         public int AttendanceId { get; set; }
         public int StudentId { get; set; }
         public int SubjectId { get; set; }
         public int Class { get; set; }
         public char Section { get; set; }
         public bool HasAttended { get; set; }
         public DateTime DateTime { get; set; }
         public int Period { get; set; }
    }
}
