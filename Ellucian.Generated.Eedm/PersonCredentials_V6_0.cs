// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a person credential
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonCredentials_V6_0
    {
        /// <summary>
        /// A global identifier of a person
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// <see cref="Credential">Credentials</see> of the person
        /// </summary>
        [JsonProperty("credentials", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<CredentialDtoProperty> Credentials { get; set; }

        /// <summary>
        /// Person credential constructor
        /// </summary>
        public PersonCredentials_V6_0()
        {
            Credentials = new List<CredentialDtoProperty>();
        }
    }
}