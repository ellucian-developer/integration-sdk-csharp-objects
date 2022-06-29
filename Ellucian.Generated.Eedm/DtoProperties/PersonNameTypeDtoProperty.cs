// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A person's name.
    /// </summary>
    [DataContract]
    public class PersonNameTypeDtoProperty
    {
        /// <summary>
        /// The <see cref="PersonNameType">type</see> of the person's name
        /// </summary>
        [JsonProperty("category")]
        public PersonNameType2? Category { get; set; }

        /// <summary>
        /// Person name type detail
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }
    }
}