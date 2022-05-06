// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Details of disbursements by award period.
    /// </summary>
    [DataContract]
    public class StudentAwardDisbursmentDtoProperty
    {
        /// <summary>
        /// The date the disbursement is scheduled to occur
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "scheduledOn")]
        public DateTime ScheduledOn { get; set; }

        /// <summary>
        /// The date the disbursement occurred
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "disbursedOn", EmitDefaultValue = false)]
        public DateTime? DisbursedOn { get; set; }

        /// <summary>
        /// Details of amounts to be distributed.
        /// </summary>
        [DataMember(Name = "amounts", EmitDefaultValue = false)]
        public StudentAwardDisbursedAmountDtoProperty Amounts { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public StudentAwardDisbursmentDtoProperty()
        {
        }
    }
}