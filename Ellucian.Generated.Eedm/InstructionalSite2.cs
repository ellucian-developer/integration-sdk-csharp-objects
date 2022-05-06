// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about the site at which an instructional event occurs
    /// </summary>
    [JsonObject("site")]
    public class InstructionalSite2 : InstructionalLocation2
    {
        /// <summary>
        /// Location type
        /// </summary>
       [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public InstructionalLocationType? LocationType { get; set; }

        /// <summary>
         /// The physical site where the event will take place
        /// </summary>
        [JsonProperty("site")]
        public GuidObject2 Site { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public InstructionalSite2()
        {
            LocationType = InstructionalLocationType.InstructionalSite;
        }
    }
}