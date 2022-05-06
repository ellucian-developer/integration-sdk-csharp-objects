// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The maximum number of persons who may occupy a Room arranged in a given layout.
    /// </summary>
    [DataContract]
    public class Occupancy
    {
        /// <summary>
        /// The type or style of a of Room's layout.
        /// </summary>
        [DataMember(Name = "roomLayoutType")]
        public RoomLayoutType RoomLayoutType { get; set; }

        /// <summary>
        /// The maximum number of persons who may occupy a Room arranged in a given layout.
        /// </summary>
        [DataMember(Name = "maxOccupancy")]
        public int MaximumOccupancy { get; set; }
    }
}