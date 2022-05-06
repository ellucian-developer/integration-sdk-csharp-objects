//Copyright 2017-2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The assignment of a student to institution provided housing. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class HousingAssignments_V10_1_0 : BaseModel2
    {
        /// <summary>
        /// A reference to the student assigned a room.
        /// </summary>
        [JsonProperty("person")]
        [FilterProperty("criteria")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The room assigned to the student.
        /// </summary>
        [JsonProperty("room", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Room { get; set; }

        /// <summary>
        /// The academic period associated with the housing assignment.
        /// </summary>
        [JsonProperty("academicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// The date the housing assignment starts.
        /// </summary>
        [JsonProperty("startOn")]
        [FilterProperty("criteria")]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// The date the housing assignment ends
        /// </summary>
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTimeOffset? EndOn { get; set; }

        /// <summary>
        /// The status of the room assignment.
        /// </summary>
        [JsonProperty("status")]
        [FilterProperty("criteria")]
        public HousingAssignmentsStatus? Status { get; set; }

        /// <summary>
        /// The date the housing assignment ends.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("statusDate", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StatusDate { get; set; }

        /// <summary>
        /// A reference to the person's request for housing.
        /// </summary>
        [JsonProperty("request", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 HousingRequest { get; set; }

        /// <summary>
        /// The contract number room assignment.
        /// </summary>
        [JsonProperty("contractNumber", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string ContractNumber { get; set; }

        /// <summary>
        /// The comments for room assignment.
        /// </summary>
        [JsonProperty("comment", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// A reference to the charge to the student for the housing assignment.
        /// </summary>
        [JsonProperty("roomRate", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 RoomRate { get; set; }

        /// <summary>
        /// The interval for which rate is defined.
        /// </summary>
        [JsonProperty("ratePeriod", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public RatePeriod? RatePeriod { get; set; }

        /// <summary>
        /// The override rate for the room assignment.
        /// </summary>
        [JsonProperty("rateOverride", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public HousingAssignmentRateOverrideProperty RateOverride { get; set; }

        /// <summary>
        /// The additional charges applied to the student for the housing assignment.
        /// </summary>
        [JsonProperty("additionalCharges", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<HousingAssignmentAdditionalChargeProperty> AdditionalCharges { get; set; }

        /// <summary>
        /// The resident type of the student for this housing assignment.
        /// </summary>
        [JsonProperty("residentType", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 ResidentType { get; set; }   
    }
}