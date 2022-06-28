// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Contact information for an instructional event
    /// </summary>
    [JsonObject("online")]
    public class InstructionalContact
    {
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
        public InstructionalContact()
        {
        }
    }
}
