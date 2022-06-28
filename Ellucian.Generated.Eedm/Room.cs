// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A room within a building, on a floor.
    /// </summary>
    [DataContract]
    public class Room : BaseModel
    {
        /// <summary>
        /// Human-readable name
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Human-readable description
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// A numbering scheme to distinguish different rooms located in the same site.
        /// </summary>
        [DataMember(Name = "number")]
        public string Number { get; set; }

        /// <summary>
        /// The name of the floor where a Room is located.
        /// </summary>
        [DataMember(Name = "floor")]
        public string Floor { get; set; }

        /// <summary>
        /// Collection of the maximum number of persons who may occupy a Room arranged in a given layout.
        /// </summary>
        [DataMember(Name = "occupancies")]
        public IEnumerable<Occupancy> Occupancies { get; set; }

        /// <summary>
        /// Globally unique identifier for a building
        /// </summary>
        [DataMember(Name = "building")]
        public GuidObject BuildingGuid { get; set; }

        /// <summary>
        /// Person constructor
        /// </summary>
        public Room() : base()
        {
        }
    }
}