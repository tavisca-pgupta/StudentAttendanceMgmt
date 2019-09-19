using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAttendanceManagementApi.Models
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectId { get; set; }
        public int ClassId { get; set; }
    }
}
