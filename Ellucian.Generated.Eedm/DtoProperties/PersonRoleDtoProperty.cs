// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Role/persona of a person.
    /// </summary>
    [DataContract]
    public class PersonRoleDtoProperty
    {
        /// <summary>
        /// The actions and activities assigned to, required of, or expected of a person.
        /// </summary>
        [JsonProperty("role")]
        [FilterProperty("criteria")]
        public PersonRoleType? RoleType { get; set; }

        /// <summary>
        /// Start date of the role.
        /// </summary>
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// End date of the role.
        /// </summary>
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? EndOn { get; set; }
    }
}