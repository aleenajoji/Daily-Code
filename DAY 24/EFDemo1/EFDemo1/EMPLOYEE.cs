//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDemo1
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPLOYEE
    {
        public int employee_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public Nullable<decimal> phone_number { get; set; }
        public Nullable<System.DateTime> hire_date { get; set; }
        public Nullable<int> job_id { get; set; }
        public Nullable<decimal> salary { get; set; }
        public Nullable<decimal> commission_pct { get; set; }
        public Nullable<int> manager_id { get; set; }
        public Nullable<int> department_id { get; set; }
    
        public virtual DEPARTMENT DEPARTMENT { get; set; }
        public virtual JOB JOB { get; set; }
    }
}