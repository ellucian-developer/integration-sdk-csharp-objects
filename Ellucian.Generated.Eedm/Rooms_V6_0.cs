// Copyright 2016-2018 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A room within a building, on a floor.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Rooms_V6_0 : BaseModel2
    {
        /// <summary>
        /// The full name of a room.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// A description of a room.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// A numbering scheme to distinguish different buildings, floors, and rooms located in the same site.  Typically this is a string..
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// The name of the floor where a room is located.
        /// </summary>
        [JsonProperty("floor", NullValueHandling = NullValueHandling.Ignore)]
        public string Floor { get; set; }

        /// <summary>
        /// The type or style of a of room's layout, for example, \"Classroom\" style, \"Lecture Hall\" style, etc.  A room may support multiple types of layouts.
        /// </summary>
        [JsonProperty("roomTypes", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<RoomType> RoomTypes { get; set; }

        /// <summary>
        /// Collection of the maximum number of persons who may occupy a Room arranged in a given layout.
        /// </summary>
        [JsonProperty("occupancies", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Occupancy2> Occupancies { get; set; }

        /// <summary>
        /// Globally unique identifier for a building
        /// </summary>
        [JsonProperty("building", NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 BuildingGuid { get; set; }

        /// <summary>
        /// Globally unique identifier for a site
        /// </summary>
        [JsonProperty("site", NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 SiteGuid { get; set; }

        /// <summary>
        /// The named section of a building in which the resides
        /// </summary>
        [JsonProperty("wing", NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Wing { get; set; }


        /// <summary>
        /// The list of characteristics specified for the room.
        /// </summary>
        [JsonProperty("roomCharacteristics", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<GuidObject2> RoomCharacteristics { get; set; }

        /// <summary>
        /// Room constructor
        /// </summary>
        public Rooms_V6_0() : base()
        {
        }
    }
}