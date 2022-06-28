// Copyright 2014-2015 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about online instructional event
    /// </summary>
    [JsonObject("online")]
    public class InstructionalOnline : InstructionalLocation
    {
        /// <summary>
        /// Location type
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public InstructionalLocationType LocationType { get; set; }

        /// <summary>
        /// The identifier for a specific contact information for online classes
        /// </summary>
        [JsonProperty("online")]
        public InstructionalContact Contact { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public InstructionalOnline()
        {
            Contact = new InstructionalContact();
            LocationType = InstructionalLocationType.InstructionalOnline;
        }
    }
}