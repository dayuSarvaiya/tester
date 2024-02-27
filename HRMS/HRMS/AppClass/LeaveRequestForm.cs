using System;
using System.Windows.Forms;

namespace HRMS
{
    internal class LeaveRequestForm
    {
        private string employeeId;
        public LeaveRequestForm(string employeeId)
        {
            this.employeeId = employeeId;
        }
        public LeaveRequest LeaveRequest { get; internal set; }
        internal DialogResult ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}