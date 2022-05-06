// Copyright 2014-2015 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about the room in which an instructional event occurs
    /// </summary>
    [JsonObject("room")]
    public class InstructionalRoom : InstructionalLocation
    {
        /// <summary>
        /// Location type
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public InstructionalLocationType LocationType { get; set; }

        /// <summary>
        /// A Globally Unique ID (GUID)
        /// </summary>
        [JsonProperty("guid")]
        public string Guid { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public InstructionalRoom()
        {
            LocationType = InstructionalLocationType.InstructionalRoom;
        }
    }
}
