// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A racial groups to which a person belongs.
    /// </summary>
    [DataContract]
    public class PersonRaceDtoProperty
    {
        /// <summary>
        /// Globally unique identifier for race
        /// </summary>
        [JsonProperty("race", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Race { get; set; }

        /// <summary>
        /// Properties required for governmental or other reporting.
        /// </summary>
        [JsonProperty("reporting", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<PersonRaceReporting> Reporting { get; set; }
    }
}