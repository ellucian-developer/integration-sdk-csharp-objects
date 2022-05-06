// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Person Benefit Dependents Dependent DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonBenefitDependentsDependentDtoProperty
    {
        /// <summary>
        /// Id of Person
        /// </summary>
        [JsonProperty("person")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// Name of dependent.
        /// </summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Date when the dependent was born.
        /// </summary>
        [JsonProperty("dateOfBirth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Marital status of dependent.
        /// </summary>
        [JsonProperty("maritalStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 MaritalStatus { get; set; }

        /// <summary>
        /// Gender of dependent.
        /// </summary>
        [JsonProperty("gender", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Gender { get; set; }

        /// <summary>
        /// Credential value of dependent.
        /// </summary>
        [JsonProperty("credentialValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CredentialValue { get; set; }

        /// <summary>
        /// Relationship of dependent.
        /// </summary>
        [JsonProperty("relationship", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Relationship { get; set; }
    }
}
