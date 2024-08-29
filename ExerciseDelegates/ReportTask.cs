﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDelegates
{
    internal class ReportTask : ITask<string>
    {
        public string ReportName  { get; set; }
        public string Perform()
        {
            return $"Report {ReportName} generate succesfully.";
        }
    }
}
