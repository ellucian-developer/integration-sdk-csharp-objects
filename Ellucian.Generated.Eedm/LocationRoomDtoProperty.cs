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
    /// LocationRoom DTO property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class LocationRoomDtoProperty : InstructionalLocationDtoProperty
    {

        /// <summary>
        /// Location type
        /// </summary>
        [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public InstructionalLocationType? LocationType { get; set; }

        /// <summary>
        /// Title of the Room
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Number of the Room
        /// </summary>
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// Floor of the Room
        /// </summary>
        [JsonProperty("floor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Floor { get; set; }

        /// <summary>
        /// Building of the Room
        /// </summary>
        [JsonProperty("building", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BuildingDtoProperty Building { get; set; }

        /// <summary>
        /// Id of the Room
        /// </summary>
        [JsonProperty("detail")]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public LocationRoomDtoProperty()
        {
            Detail = new GuidObject2();
            LocationType = InstructionalLocationType.InstructionalRoom;
        }
    }
}