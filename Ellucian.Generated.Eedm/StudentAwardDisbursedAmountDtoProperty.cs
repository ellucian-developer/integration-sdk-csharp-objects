// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Details of amounts to be distributed.
    /// </summary>
    [DataContract]
    public class StudentAwardDisbursedAmountDtoProperty
    {
        /// <summary>
        /// The amount anticipated to be distributed
        /// </summary>
        [DataMember(Name = "plannedAmount", EmitDefaultValue = false)]
        public AmountDtoProperty PlannedAmount { get; set; }

        /// <summary>
        /// The amount that was actually distributed
        /// </summary>
        [DataMember(Name = "actualAmount", EmitDefaultValue = false)]
        public AmountDtoProperty ActualAmount { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public StudentAwardDisbursedAmountDtoProperty()
        {
        }
    }
}