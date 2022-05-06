// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Financial Aid Year
    /// </summary>
    [DataContract]
    public class FinancialAidYears_V7_1_0 : CodeItem2
    {
        /// <summary>
        /// Status
        /// </summary>
        [DataMember(Name = "status")]
        public FinancialAidYearStatus Status { get; set; }

        /// <summary>
        /// Start
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "startOn", EmitDefaultValue= false)]
        public DateTime? Start { get; set; }


        /// <summary>
        /// End
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        public DateTime? End { get; set; }


    }
}
