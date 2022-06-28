//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Assignments of meal plans to students. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MealPlanAssignments_V10_0_0 : BaseModel2
    {
        /// <summary>
        /// The person to whom a meal plan is assigned.
        /// </summary>
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The meal plan assigned to the person.
        /// </summary>
        [JsonProperty("mealPlan", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 MealPlan { get; set; }

        /// <summary>
        /// The academic period for the meal plan assignment.
        /// </summary>
        [JsonProperty("academicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// The start date when the meal plan assignments become effective.
        /// </summary>
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// The end date of the meal plan assignment.
        /// </summary>
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTimeOffset? EndOn { get; set; }

        /// <summary>
        /// The status of the meal plan assignment.
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public StudentMealPlansStatus? Status { get; set; }

        /// <summary>
        /// The date when the meal plan assignment status was set or modified.
        /// </summary>
        [JsonProperty("statusDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? StatusDate { get; set; }

        /// <summary>
        /// The rate associated with the meal plan assignment.
        /// </summary>
        [JsonProperty("assignedRate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AssignedRate { get; set; }

        /// <summary>
        /// The number of time periods in the meal plan assignment.
        /// </summary>
        [JsonProperty("numberOfPeriods", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? NumberOfPeriods { get; set; }

        /// <summary>
        /// The override rate for the meal plan assignment.
        /// </summary>
        [JsonProperty("rateOverride", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentMealPlansOverrideRateDtoProperty OverrideRate { get; set; }

        /// <summary>
        /// The consumption data of the meal plan assignment
        /// </summary>
        [JsonProperty("consumption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentMealPlansConsumption Consumption { get; set; }

        /// <summary>
        /// The meal plan card
        /// </summary>
        [JsonProperty("mealCard", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MealCard { get; set; }

        /// <summary>
        /// The meal plan comments
        /// </summary>
        [JsonProperty("comment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Comment { get; set; }
    }
}
