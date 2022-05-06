
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
    /// The range of possible numeric scores on the assessment.
    /// </summary>
    [DataContract]
    public class ValidScoreRangeProperty
    {
        /// <summary>
        /// The lowest possible score on the assessment.
        /// </summary>
        [DataMember(Name = "minimum", EmitDefaultValue = false)]
        public int? ValidScoreMinimum { get; set; }

        /// <summary>
        /// The highest possible score on the assessment.
        /// </summary>
        [DataMember(Name = "maximum", EmitDefaultValue = false)]
        public int? ValidScoreMaximum { get; set; }
    }
}
