// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The citizenship status of the person with regards to the country where a given institution is located.
    /// </summary>
    [DataContract]
    public class PersonIdentityDocumentType
    {
        /// <summary>
        /// Citizenship status category.
        /// </summary>
        [JsonProperty("category")]
        public PersonIdentityDocumentCategory? Category { get; set; }

        /// <summary>
        /// Globally unique identifier for marital status code
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }
    }
}