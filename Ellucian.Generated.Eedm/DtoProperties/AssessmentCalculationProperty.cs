// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type and method of the calculations to be used to determent the assessment score.
    /// </summary>
    [DataContract]
    public class AssessmentCalculationProperty
    {
        /// <summary>
        /// The type of calculation to be applied the assessment score.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public CalculationType CalculationType { get; set; }

        /// <summary>
        /// The calculation method to determine the assessment's score.
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public GuidObject2 CalculationMethod { get; set; }
    }
}
