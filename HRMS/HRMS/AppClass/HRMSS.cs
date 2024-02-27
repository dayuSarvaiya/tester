using System;
using System.Collections.Generic;

namespace HRMS
{
    internal class HRMSS
    {
        public object Employees { get; internal set; }

        internal void AddFeedback(int employeeId, string comment)
        {
            throw new NotImplementedException();
        }

        internal void AddWorkDetail(string employeeId, WorkDetail newWorkDetail)
        {
            throw new NotImplementedException();
        }

        internal List<WorkDetail> GetWorkDetails(string employeeId)
        {
            throw new NotImplementedException();
        }
    }
}