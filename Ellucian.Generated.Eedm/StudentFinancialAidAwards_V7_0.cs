// Copyright 2017 Ellucian Company L.P. an?d its affiliates.

using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about student financial aid awards.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentFinancialAidAwards_V7_0 : BaseModel2
    {
        /// <summary>
        /// Student who will be receiving the financial aid award.
        /// </summary>
        [JsonProperty("student")]
        public GuidObject2 Student { get; set; }

        /// <summary>
        /// The fund that is awarded to the student. 
        /// </summary>
        [JsonProperty("awardFund", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AwardFund { get; set; }

        /// <summary>
        /// The year that the award is assigned.
        /// </summary>
        [JsonProperty("aidYear", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AidYear { get; set; }
        
        /// <summary>
        /// Date of the first offer
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("originallyOfferedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? OriginallyOfferedOn { get; set; }

        /// <summary>
        /// Financial award details by period.
        /// </summary>
        [JsonProperty("awardsByPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<StudentAwardsByPeriodDtoProperty> AwardsByPeriod { get; set; }

    }
}
