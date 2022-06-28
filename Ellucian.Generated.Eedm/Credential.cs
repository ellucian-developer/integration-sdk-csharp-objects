// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a person's credential
    /// </summary>
    [DataContract]
    public class Credential
    {
        /// <summary>
        /// The <see cref="CredentialType">type</see> of credential
        /// </summary>
        [DataMember(Name = "credentialType")]
        public CredentialType? CredentialType { get; set; }

        /// <summary>
        /// The ID of the credential
        /// </summary>
        [DataMember(Name = "credentialId")]
        public string Id { get; set; }

        /// <summary>
        /// The effective start date
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "effectiveStartDate")]
        public DateTime? EffectiveStartDate { get; set; }

        /// <summary>
        /// The effective end date
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "effectiveEndDate")]
        public DateTime? EffectiveEndDate { get; set; }
    }
}