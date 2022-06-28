// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Financial Aid Award Period
    /// </summary>
    [DataContract]
    public class FinancialAidAwardPeriods_V7_0 : CodeItem2
    {
        /// <summary>
        /// Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

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
