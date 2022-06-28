// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The maximum number of persons who may occupy a Room arranged in a given layout.
    /// </summary>
    [DataContract]
    public class Occupancy2
    {
        /// <summary>
        /// For rooms with multiple layout, this can be used. For example, a gymnasium can be used for a seminar or a conference, with different maximum occupancies. For rooms with single occupancy type, \"Default\" can be used.
        /// </summary>
        [DataMember(Name = "type")]
        public RoomLayoutType2 RoomLayoutType { get; set; }

        /// <summary>
        /// The maximum number of persons who may occupy a Room arranged in a given layout.
        /// </summary>
        [DataMember(Name = "maxOccupancy")]
        public int MaximumOccupancy { get; set; }
    }
}