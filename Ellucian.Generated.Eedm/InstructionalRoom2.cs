// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about the room in which an instructional event occurs
    /// </summary>
    [JsonObject("room")]
    public class InstructionalRoom2 : InstructionalLocation2
    {
        /// <summary>
        /// Location type
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public InstructionalLocationType? LocationType { get; set; }

        /// <summary>
        /// room where the event will take place.
        /// </summary>
        [JsonProperty("room")]
        public GuidObject2 Room { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public InstructionalRoom2()
        {
            LocationType = InstructionalLocationType.InstructionalRoom;
        }
    }
}