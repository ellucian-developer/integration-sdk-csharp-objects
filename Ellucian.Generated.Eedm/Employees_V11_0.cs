// Copyright 2016-2018 Ellucian Company L.P. an?d its affiliates.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about persons employed in the institution.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Employees_V11_0 : BaseModel2
    {
        /// <summary>
        /// A reference to link an employee to the common persons entity. This property represents the global identifier for the Person.
        /// </summary>
        [JsonProperty("person")]
        [FilterProperty("criteria")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The physical location assigned to an employee. This property represents the global identifier for the Campus.
        /// </summary>
        [JsonProperty("campus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Campus { get; set; }

        /// <summary>
        /// The home department or organization of the employee. The global identifier for the Department.
        /// </summary>
        [JsonProperty("homeOrganization", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 HomeOrganization { get; set; }

        /// <summary>
        /// The employee status code (Eg. Full-time or Part-time).
        /// </summary>
        [JsonProperty("contract", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public ContractTypeDtoProperty Contract { get; set; }

        /// <summary>
        /// The classification assigned to the employee, or their primary job, that may impact payroll processing such as time entry methods, earning types and pay periods.
        /// </summary>
        [JsonProperty("payClass", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 PayClass { get; set; }

        /// <summary>
        /// The pay status of the employee (with pay, without pay or partial pay).
        /// </summary>
        [JsonProperty("payStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PayStatus? PayStatus { get; set; }

        /// <summary>
        /// The benefits status of the employee (with or without benefits).
        /// </summary>
        [JsonProperty("benefitsStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BenefitsStatus? BenefitsStatus { get; set; }

        /// <summary>
        /// The number of hours worked per period. This property represents the time period for which working hours are considered.
        /// </summary>
        [JsonProperty("hoursPerPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<HoursPerPeriodDtoProperty> HoursPerPeriod { get; set; }

        /// <summary>
        /// The employment status (active, terminated, on leave).
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public EmployeeStatus? Status { get; set; }

        /// <summary>
        /// The first date of employment.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The last date of employment.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// The reason for employment termination. This property represents the global identifier for the Termination Reason.
        /// </summary>
        [JsonProperty("terminationReason", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 TerminationReason { get; set; }

        /// <summary>
        /// The eligibility status for being rehired.
        /// </summary>
        [JsonProperty("rehireableStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public RehireableStatusDtoProperty RehireableStatus { get; set; }

        /// <summary>
        /// The reason for leave of absence. This property will represent the global identifier for the Leave Reason.
        /// </summary>
        [JsonProperty("leaveReason", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 LeaveReason { get; set; }
    }
}