
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
    /// The valid scores that may be awarded for the assessment.
    /// </summary>
    [DataContract]
    public class ValidScoreProperty
    {
        /// <summary>
        /// The range of possible numeric scores on the assessment.
        /// </summary>
        [DataMember(Name = "range", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ValidScoreRangeProperty ValidScoreRange { get; set; }
    }
}
