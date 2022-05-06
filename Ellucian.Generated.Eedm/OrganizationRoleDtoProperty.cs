// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Organization Role DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class OrganizationRoleDtoProperty
    {
        /// <summary>
        /// The role type of the organization
        /// </summary>
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public OrganizationRoleType? Type { get; set; }

        /// <summary>
        /// The effective start date
        /// </summary>
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// The effective end date
        /// </summary>
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? EndOn { get; set; }
    }
}
