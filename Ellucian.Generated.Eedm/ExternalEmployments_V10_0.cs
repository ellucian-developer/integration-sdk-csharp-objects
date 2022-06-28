// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about applicants' or employees' previous employments. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ExternalEmployments_V10_0 : BaseModel2
    {
        /// <summary>
        /// The person associated with the external employment.
        /// </summary>

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The position associated with the external employment.
        /// </summary>

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Position { get; set; }

        /// <summary>
        /// The organization associated with the external employment.
        /// </summary>

        [JsonProperty("organization", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ExternalEmploymentsOrganization Organization { get; set; }

        /// <summary>
        /// The start of employment at the organization.
        /// </summary>

        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateDtoProperty StartOn { get; set; }

        /// <summary>
        /// The end of employment at the organization.
        /// </summary>

        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateDtoProperty EndOn { get; set; }

        /// <summary>
        /// The salary or wages earned.
        /// </summary>

        [JsonProperty("compensation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ExternalEmploymentsCompensation Compensation { get; set; }

        /// <summary>
        /// The job title for the external employment.
        /// </summary>

        [JsonProperty("jobTitle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string JobTitle { get; set; }

        /// <summary>
        /// The job responsibilities of the external employment.
        /// </summary>

        [JsonProperty("jobDescription", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string JobDescription { get; set; }

        /// <summary>
        /// An indication whether the position was considered as primary for the employee.
        /// </summary>

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ExternalEmploymentsPriority Priority { get; set; }

        /// <summary>
        /// The status of the external employment.
        /// </summary>

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Status { get; set; }

        /// <summary>
        /// The number of hours the person worked per period.
        /// </summary>

        [JsonProperty("hoursWorked", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public HoursPerPeriodDtoProperty HoursWorked { get; set; }

        /// <summary>
        /// The vocations associated with the external employment.
        /// </summary>

        [JsonProperty("vocations", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> Vocations { get; set; }

        /// <summary>
        /// The supervisors of the person for the external employment.
        /// </summary>

        [JsonProperty("supervisors", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<ExternalEmploymentsSupervisors> Supervisors { get; set; }

        /// <summary>
        /// The number of employees supervised.
        /// </summary>

        [JsonProperty("employeesSupervised", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? EmployeesSupervised { get; set; }

        /// <summary>
        /// The reason given for leaving the external employment.
        /// </summary>

        [JsonProperty("leavingReason", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LeavingReason { get; set; }

        /// <summary>
        /// Any comment associated with the external employment.
        /// </summary>

        [JsonProperty("comment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Comment { get; set; }

    }
}
