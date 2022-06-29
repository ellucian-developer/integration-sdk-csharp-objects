// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Credential DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CredentialDtoProperty
    {
        /// <summary>
        /// The credential type of the credential
        /// </summary>
        [JsonProperty("type")]
        public CredentialType? Type { get; set; }

        /// <summary>
        /// The value of the credential
        /// </summary>
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
