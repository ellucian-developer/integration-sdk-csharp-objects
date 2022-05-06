//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information on leave plan options offered by the employer. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class LeavePlans_V11_0 : CodeItem2
    {
        /// <summary>
        /// The type of leave (e.g. sick, vacation, etc.).
        /// </summary>

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Type { get; set; }

        /// <summary>
        /// The category associated with the leave plan.
        /// </summary>

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Category { get; set; }

        /// <summary>
        /// The method by which leave can be accumulated.
        /// </summary>

        [JsonProperty("accrualMethod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LeavePlansAccrualMethod AccrualMethod { get; set; }

        /// <summary>
        /// An indication whether the leave plan can be used before accrual or after accrual.
        /// </summary>

        [JsonProperty("usage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LeavePlansUsage Usage { get; set; }

        /// <summary>
        /// The start date of the leave plan.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The end date of the leave plan.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// The default start of the plan in a year.
        /// </summary>

        [JsonProperty("planYearStart", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateDtoProperty PlanYearStart { get; set; }

        /// <summary>
        /// The type of leave that can be rolled over from one plan to another at the end of plan year.
        /// </summary>

        [JsonProperty("alternateRolloverLeaveType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AlternateRolloverLeaveType { get; set; }

        /// <summary>
        /// The frequency at which leave accrues.
        /// </summary>

        [JsonProperty("accrualFrequency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AccrualFrequency { get; set; }

        /// <summary>
        /// The amount of time an employee must wait until he/she can take a leave.
        /// </summary>

        [JsonProperty("waitDays", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Decimal? WaitDays { get; set; }

    }
}
