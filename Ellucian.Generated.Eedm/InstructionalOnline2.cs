// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about online instructional event
    /// </summary>
    [JsonObject("online")]
    public class InstructionalOnline2 : InstructionalLocation2
    {
        /// <summary>
        /// Location type
        /// </summary>
       [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public InstructionalLocationType? LocationType { get; set; }

       /// <summary>
       /// Telephone number
       /// </summary>
       [JsonProperty("phoneNumber")]
       public string PhoneNumber { get; set; }

       /// <summary>
       /// Telephone extension
       /// </summary>
       [JsonProperty("phoneExtension")]
       public string PhoneExtension { get; set; }

       /// <summary>
       /// Internet address
       /// </summary>
       [JsonProperty("webAddress")]
       public string WebAddress { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
       [JsonConstructor]
       public InstructionalOnline2()
       {
           //Contact = new InstructionalContact();
           LocationType = InstructionalLocationType.InstructionalOnline;
       }
    }
}