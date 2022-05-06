// Copyright 2015-2017 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A room within a building, on a floor.
    /// </summary>
    [DataContract]
    public class Room2 : BaseModel2
    {
        /// <summary>
        /// The full name of a room.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// A description of a room.
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// A numbering scheme to distinguish different buildings, floors, and rooms located in the same site.  Typically this is a string..
        /// </summary>
        [DataMember(Name = "number")]
        public string Number { get; set; }

        /// <summary>
        /// The name of the floor where a room is located.
        /// </summary>
        [DataMember(Name = "floor", EmitDefaultValue = false)]
        public string Floor { get; set; }

        /// <summary>
        /// The type or style of a of room's layout, for example, \"Classroom\" style, \"Lecture Hall\" style, etc.  A room may support multiple types of layouts.
        /// </summary>
        [DataMember(Name = "roomTypes", EmitDefaultValue = false)]
        public IEnumerable<RoomType> RoomTypes { get; set; }

        /// <summary>
        /// Collection of the maximum number of persons who may occupy a Room arranged in a given layout.
        /// </summary>
        [DataMember(Name = "occupancies", EmitDefaultValue = false)]
        public IEnumerable<Occupancy2> Occupancies { get; set; }

        /// <summary>
        /// Globally unique identifier for a building
        /// </summary>
        [DataMember(Name = "building", EmitDefaultValue = false)]
        public GuidObject2 BuildingGuid { get; set; }

        /// <summary>
        /// Globally unique identifier for a site
        /// </summary>
        [DataMember(Name = "site", EmitDefaultValue = false)]
        public GuidObject2 SiteGuid { get; set; }

        /// <summary>
        /// Room constructor
        /// </summary>
        public Room2() : base()
        {
        }
    }
}