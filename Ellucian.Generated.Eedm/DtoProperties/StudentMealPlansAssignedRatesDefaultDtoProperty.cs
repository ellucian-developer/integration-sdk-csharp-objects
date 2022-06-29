// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Interfaces;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The rate associated with the meal plan assignment.
    /// </summary>
    [DataContract]
    public class StudentMealPlanAssignedRatesDefaultDtoProperty : IAssignedRatesDtoProperty
    {
        /// <summary>
        /// The effective regular rate for the meal plan.
        /// </summary>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        public GuidObject2 Rate { get; set; }

        /// <summary>
        /// The number of periods for the rate.
        /// </summary>
        [DataMember(Name = "numberOfPeriods", EmitDefaultValue = false)]
        public int? NumberOfPeriods { get; set; }

    }
}