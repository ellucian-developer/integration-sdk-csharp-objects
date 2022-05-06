// Copyright 2014 Ellucian Company L.P. and its affiliates
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A GUID container
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GuidObject
    {
        /// <summary>
        /// Globally unique Identifier (GUID)
        /// </summary>
        [JsonProperty("guid")]
        public string Guid { get; set; }

        /// <summary>
        /// Constructor for GuidObject
        /// </summary>
        [JsonConstructor]
        public GuidObject()
        {
        }

        /// <summary>
        /// Constructor for GuidObject
        /// </summary>
        /// <param name="guid">Globally unique identifier</param>
        public GuidObject(string guid)
        {
            Guid = guid;
        }
    }
}