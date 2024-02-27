using System;

namespace HRMS
{
    internal class WorkDetail
    {
        public int Hours { get; internal set; }
        public DateTime Date { get; internal set; }
        public string Task { get; internal set; }
    }
}