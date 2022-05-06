// Copyright 2014-2020 Ellucian Company L.P. and its affiliates
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A GUID container
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GuidObject2
    {
        /// <summary>
        /// Globally unique Identifier (GUID)
        /// </summary>
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Constructor for GuidObject
        /// </summary>
        [JsonConstructor]
        public GuidObject2()
        {
        }

        /// <summary>
        /// Constructor for GuidObject
        /// </summary>
        /// <param name="id">Globally unique identifier</param>
        public GuidObject2(string id)
        {
            Id = id;
        }
    }
}