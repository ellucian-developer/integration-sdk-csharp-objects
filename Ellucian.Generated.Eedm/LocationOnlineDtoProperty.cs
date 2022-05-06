// Copyright 2015 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Academic Levels DTO property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class LocationOnlineDtoProperty : BaseCodeTitleDetailDtoProperty, InstructionalLocationDtoProperty
    {

        /// <summary>
        /// Location type
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public InstructionalLocationType? LocationType { get; set; }

        /// <summary>
        /// Telephone number
        /// </summary>
        [JsonProperty("phoneNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Telephone extension
        /// </summary>
        [JsonProperty("phoneExtension", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PhoneExtension { get; set; }

        /// <summary>
        /// Internet address
        /// </summary>
        [JsonProperty("webAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string WebAddress { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public LocationOnlineDtoProperty() : base()
        {
            LocationType = InstructionalLocationType.InstructionalOnline;
        }
    }
}