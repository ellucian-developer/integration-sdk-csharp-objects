//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A detailed description of the job at an institution. 
    /// </summary>
    [DataContract]
    public class InstitutionJobs_V11_0 : BaseModel2
    {
        
        /// <summary>
        /// The employee to which the job is associated.
        /// </summary>
        [DataMember(Name = "person")]
        [FilterProperty("criteria")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The operational unit of the institution to which the job belongs.
        /// </summary>
        [DataMember(Name = "employer")]
        [FilterProperty("criteria")]
        public GuidObject2 Employer { get; set; }

        /// <summary>
        /// The position associated with the job.
        /// </summary>
        [DataMember(Name = "position")]
        [FilterProperty("criteria")]
        public GuidObject2 Position { get; set; }

        /// <summary>
        /// The department of the institution to which the job belongs.
        /// </summary>
        [DataMember(Name = "department")]
        [FilterProperty("criteria")]
        public string Department { get; set; }

        /// <summary>
        /// The first day of the job.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "startOn")]
        [FilterProperty("criteria")]
        public DateTime StartOn { get; set; }

        /// <summary>
        /// The last day of the job.
        /// </summary>
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        [JsonConverter(typeof(DateOnlyConverter))]
        [FilterProperty("criteria")]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// The reason associated with the change of job.
        /// </summary>
        [DataMember(Name = "jobChangeReason", EmitDefaultValue = false)]
        public GuidObject2 JobChangeReason { get; set; }

        /// <summary>
        /// The accounting strings associated with the job.
        /// </summary>
        [DataMember(Name = "accountingStringAllocations", EmitDefaultValue = false)]
        public List<AccountingStringAllocationsDtoProperty> AccountingStringAllocations { get; set; }

        /// <summary>
        /// The status of the employee on the job.
        /// </summary>
        [DataMember(Name = "status")]
        [FilterProperty("criteria")]
        public InstitutionJobsStatus? Status { get; set; }

            /// <summary>
        /// The number of hours of work in specified time periods.
        /// </summary>
        [DataMember(Name = "hoursPerPeriod", EmitDefaultValue = false)]
        public List<HoursPerPeriodDtoProperty> HoursPerPeriod { get; set; }

        /// <summary>
        /// The ratio of hours of work for the position to the hours of work expected of a full-time employee.
        /// </summary>
        [DataMember(Name = "fullTimeEquivalent", EmitDefaultValue = false)]
        public decimal? FullTimeEquivalent { get; set; }

        /// <summary>
        /// The percentage of the position filled by the employee.
        /// </summary>
        [DataMember(Name = "appointmentPercentage", EmitDefaultValue = false)]
        public int AppointmentPercentage { get; set; }

        /// <summary>
        /// The supervisor associated with the job.
        /// </summary>
        [DataMember(Name = "supervisors", EmitDefaultValue = false)]
        public List<SupervisorsDtoProperty> Supervisors { get; set; }

        /// <summary>
        /// The details of the salary associated with the job.
        /// </summary>
        [DataMember(Name = "salaries", EmitDefaultValue = false)]
        public List<SalaryDtoProperty> Salaries { get; set; }

        /// <summary>
        /// The employment classification of the job.
        /// </summary>
        [DataMember(Name = "classification", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public GuidObject2 Classification { get; set; }

        /// <summary>
        /// The preference for a job (primary).
        /// </summary>
        [DataMember(Name = "preference", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public JobPreference? Preference { get; set; }

    }
}
