// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The current marital state (for example, single, married, or divorced) of the person.
    /// </summary>
    [DataContract]
    public class PersonMaritalStatusDtoProperty
    {
        /// <summary>
        /// The higher-level marital category of the person.
        /// </summary>
        [JsonProperty("maritalCategory")]
        public PersonMaritalStatusCategory? MaritalCategory { get; set; }

        /// <summary>
        /// Globally unique identifier for marital status code
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }
    }
}