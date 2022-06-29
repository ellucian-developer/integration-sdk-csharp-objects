// Copyright 2019 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Attributes;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A person matching request names object.
    /// </summary>
    [DataContract]
    public class PersonMatchingRequestNamesDtoProperty
    {
        /// <summary>
        /// Person's first name
        /// </summary>
        [JsonProperty("legal", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonMatchingRequestNamesNameDtoProperty Legal { get; set; }

        /// <summary>
        /// Person's middle name
        /// </summary>
        [JsonProperty("former", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonMatchingRequestNamesNameDtoProperty Former { get; set; }

        /// <summary>
        /// Person's last name
        /// </summary>
        [JsonProperty("favored", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonMatchingRequestNamesNameDtoProperty Favored { get; set; }
    }
}