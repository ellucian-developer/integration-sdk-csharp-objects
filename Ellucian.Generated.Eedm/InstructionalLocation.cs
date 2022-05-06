// Copyright 2014-2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about the location at which an instructional event occurs
    /// </summary>
    [JsonArray("locations")]
    public interface InstructionalLocation
    {
        /// <summary>
        /// Location type
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        InstructionalLocationType LocationType { get; set; }
    }
}