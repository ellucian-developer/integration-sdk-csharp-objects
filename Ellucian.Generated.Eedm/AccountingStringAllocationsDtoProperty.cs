// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Converters;
using System;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The accounting strings with allocated percentages associated with the job
    /// </summary>
    [DataContract]
    public class AccountingStringAllocationsDtoProperty
    {
        /// <summary>
        /// The accounting string associated with the account detail item.
        /// </summary>
        [DataMember(Name = "accountingString", EmitDefaultValue = false)]
        public string AccountingString { get; set; }

        /// <summary>
        /// The percentage allocation of the job expenses to the accounting string
        /// </summary>
        [DataMember(Name = "allocatedPercentage", EmitDefaultValue = false)]
        public decimal? AllocatedPercentage { get; set; }

        /// <summary>
        /// The start date associated with the accounting string
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "startOn", EmitDefaultValue = false)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The end date associated with the accounting string
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        public DateTime? EndOn { get; set; }

    }
}