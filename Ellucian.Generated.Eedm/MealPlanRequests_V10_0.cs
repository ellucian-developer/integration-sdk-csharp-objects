using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Requests for campus meal plans. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MealPlanRequests_V10_0 : BaseModel2
    {
        /// <summary>
        /// Person applying for a meal plan
        /// </summary>

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The meal plan the person requested
        /// </summary>

        [JsonProperty("mealPlan", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 MealPlan { get; set; }

        /// <summary>
        /// The academic period for which the meal plan is requested
        /// </summary>

        [JsonProperty("academicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// The requested start date of the meal plan
        /// </summary>
        
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// The requested end date of the meal plan
        /// </summary>
       
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? EndOn { get; set; }

        /// <summary>
        /// The date when the request was submitted
        /// </summary>
      
        [JsonProperty("submittedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? SubmittedOn { get; set; }

        /// <summary>
        /// The status of the request
        /// </summary>

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MealPlanRequestsStatus? Status { get; set; }

    }
}          

