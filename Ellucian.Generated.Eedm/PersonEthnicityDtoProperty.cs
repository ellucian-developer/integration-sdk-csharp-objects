// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The ethnicity association of the person.
    /// </summary>
    [DataContract]
    public class PersonEthnicityDtoProperty
    {
        /// <summary>
        /// Globally unique identifier for ethnicity
        /// </summary>
        [JsonProperty("ethnicGroup", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 EthnicGroup { get; set; }

        /// <summary>
        /// Properties required for governmental or other reporting.
        /// </summary>
        [JsonProperty("reporting", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<PersonEthnicityReporting> Reporting { get; set; }
    }
}