﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TimesheetRestApi2021syksy.Models
{
    public partial class Timesheet
    {
        public int IdTimesheet { get; set; }
        public int IdCustomer { get; set; }
        public int IdEmployee { get; set; }
        public int IdWorkAssignment { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StopTime { get; set; }
        public string Comments { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? Active { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public virtual Customer IdCustomerNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
        public virtual WorkAssignment IdWorkAssignmentNavigation { get; set; }
    }
}
