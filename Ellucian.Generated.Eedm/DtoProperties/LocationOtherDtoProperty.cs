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
    public class LocationOtherDtoProperty : InstructionalLocationDtoProperty
    {

        /// <summary>
        /// Location type
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public InstructionalLocationType? LocationType { get; set; }

        /// <summary>
        /// Title of the InstructionalPlatform
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public LocationOtherDtoProperty()
        {
            LocationType = InstructionalLocationType.InstructionalOtherLocation;
        }
    }
}