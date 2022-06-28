// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Role/persona of a person.
    /// </summary>
    [DataContract]
    public class Role
    {
        /// <summary>
        /// The actions and activities assigned to, required of, or expected of a person.
        /// </summary>
        [DataMember(Name = "role")]
        public RoleType RoleType { get; set; }

        /// <summary>
        /// Start date of the role.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "effectiveStartDate")]
        public DateTime? EffectiveStartDate { get; set; }

        /// <summary>
        /// End date of the role.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "effectiveEndDate")]
        public DateTime? EffectiveEndDate { get; set; }
    }
}