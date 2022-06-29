// Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// InstructorCredential DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InstructorCredential3DtoProperty
    {
        /// <summary>
        /// The credential type of the credential
        /// </summary>
        [JsonProperty("type")]
        public Credential3Type? Type { get; set; }

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
