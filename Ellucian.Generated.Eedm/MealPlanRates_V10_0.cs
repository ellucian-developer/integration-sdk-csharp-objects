// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The billing rates for meal plans. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MealPlanRates_V10_0 : CodeItem2
    {
        /// <summary>
        /// The meal plan to which the rate applies.
        /// </summary>
        [JsonProperty("mealPlan", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 MealPlan { get; set; }

        /// <summary>
        /// The meal plan rate.
        /// </summary>
        [JsonProperty("rate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Amount2DtoProperty Rate { get; set; }

        /// <summary>
        /// The time period for the rate.
        /// </summary>
        [JsonProperty("ratePeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MealPlanRatesRatePeriod RatePeriod { get; set; }

        /// <summary>
        /// A term within an academic year for which the rate is defined.
        /// </summary>
        [JsonProperty("academicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// The start date for the rate.
        /// </summary>
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// The end date for the rate.
        /// </summary>
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? EndOn { get; set; }

        /// <summary>
        /// The accounting code associated with the rate.
        /// </summary>
        [JsonProperty("accountingCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AccountingCode { get; set; }

    }
}
