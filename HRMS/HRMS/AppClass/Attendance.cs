using System;

namespace HRMS
{
    internal class Attendance
    {
        public string EmployeeId { get; internal set; }
        public DateTime Date { get; internal set; }
        public bool IsPresent { get; internal set; }
    }
}