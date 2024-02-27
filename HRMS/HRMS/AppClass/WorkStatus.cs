using System;

namespace HRMS
{
    internal class WorkStatus
    {
        private DateTime date;
        private double hoursWorked;
        private string status;

        public WorkStatus(DateTime date, double hoursWorked, string status)
        {
            this.date = date;
            this.hoursWorked = hoursWorked;
            this.status = status;
        }
    }
}