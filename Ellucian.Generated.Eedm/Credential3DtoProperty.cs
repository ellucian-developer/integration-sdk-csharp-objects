// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Credential DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Credential3DtoProperty
    {
        /// <summary>
        /// The credential type of the credential
        /// </summary>
        [JsonProperty("type")]
        [FilterProperty("criteria")]
        public Credential3Type? Type { get; set; }

        /// <summary>
        /// The value of the credential
        /// </summary>
        [FilterProperty("criteria")]
        [JsonProperty("value")]
        public string Value { get; set; }

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
