using System;

namespace SingleResponsibilityPrinciple
{
    // Employee data comes from a different database
    // Employee algorithms are subject to different checks and processes.
    public class EmployeeAccount
    {
        public Guid AccountId { get; set; }
        public Profile Profile { get; set; }
        public Address Address { get; set; }
    }
}