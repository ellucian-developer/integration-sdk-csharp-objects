// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A generic name and person property
    /// </summary>
    [DataContract]
    public class NamePersonDtoProperty
    {
        /// <summary>
        /// A name
        /// </summary>
         [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The individual person
        /// </summary>
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Person { get; set; }
    }
}