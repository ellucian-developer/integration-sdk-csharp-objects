// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Ellucian.Generated.Eedm.Interfaces;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The override rate for the meal plan assignment.
    /// </summary>
    [DataContract]
    public class StudentMealPlanAssignedRatesOverrideDtoProperty : IAssignedRatesDtoProperty
    {

        /// <summary>
        /// The effective regular rate for the meal plan.
        /// </summary>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        public Amount2DtoProperty Rate { get; set; }

        /// <summary>
        /// The period for which the rate is set.
        /// </summary>
        [DataMember(Name = "ratePeriod", EmitDefaultValue = false)]
        public MealPlanRatesRatePeriod  RatePeriod { get; set; }

        /// <summary>
        /// The number of time periods in the meal plan assignment.
        /// </summary>
        [DataMember(Name = "numberOfPeriods", EmitDefaultValue = false)]
        public int? NumberOfPeriods { get; set; }


        /// <summary>
        /// The reason for the rate override.
        /// </summary>
        [DataMember(Name = "overrideReason", EmitDefaultValue = false)]
        public GuidObject2 OverrideReason { get; set; }

        /// <summary>
        /// The accounting code associated with the override rate.
        /// </summary>
        [DataMember(Name = "accountingCode", EmitDefaultValue = false)]
        public GuidObject2 AccountingCode { get; set; }

    }
}