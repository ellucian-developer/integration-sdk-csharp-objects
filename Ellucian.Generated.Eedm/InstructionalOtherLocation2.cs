// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about an "other" location at which an instructional event occurs
    /// </summary>
    [JsonObject("other")]
    public class InstructionalOtherLocation2 : InstructionalLocation2
    {
        /// <summary>
        /// Location type
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public InstructionalLocationType? LocationType { get; set; }

        /// <summary>
        /// A text description of some other location
        /// </summary>
        [JsonProperty("title")]
        public GuidObject2 Title { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public InstructionalOtherLocation2()
        {
            LocationType = InstructionalLocationType.InstructionalOtherLocation;
        }
    }
}
