//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// It provides information on the registration eligibility of the student. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentRegistrationEligibilities_V9_0
    {
        /// <summary>
        /// The student for which registration eligibility is provided.
        /// </summary>

        [JsonProperty("student", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Student { get; set; }

        /// <summary>
        /// The academic period for which registration eligibility is provided.
        /// </summary>

        [JsonProperty("academicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// The date when a student may first register for the academic period.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime StartOn { get; set; }

        /// <summary>
        /// The last date when a student may register for the academic period.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime EndOn { get; set; }

        /// <summary>
        /// An indication if an alternate pin is required for the student to register.
        /// </summary>

        [JsonProperty("alternatePin", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentRegistrationEligibilitiesAlternatePin AlternatePin { get; set; }

        /// <summary>
        /// The indication if the student is eligible to register for the academic period.
        /// </summary>

        [JsonProperty("eligibilityStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentRegistrationEligibilitiesEligibilityStatus EligibilityStatus { get; set; }

        /// <summary>
        /// The reasons the student is not eligibile to register.
        /// </summary>

        [JsonProperty("ineligibilityReasons", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> IneligibilityReasons { get; set; }

        /// <summary>
        /// Time periods when the student is assigned priority registration.
        /// </summary>

        [JsonProperty("priorityRegistrationTimeSlots", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<StudentRegistrationEligibilitiesPriorityRegistrationTimeSlots> PriorityRegistrationTimeSlots { get; set; }

    }
}
