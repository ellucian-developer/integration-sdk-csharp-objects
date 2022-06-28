// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A request to list the rooms that are available within a given time frame, room layout, 
    /// and occupancy, in a given building, at a given site
    /// </summary>
    [DataContract]
    public class RoomsAvailabilityRequest3
    {
        /// <summary>
        /// The type or style of a of room's layout, for example, \"Classroom\" style, \"Lecture Hall\" style, etc..
        /// </summary>
        [DataMember(Name = "occupancies")]
        public IEnumerable<Occupancy2> Occupancies { get; set; }

        /// <summary>
        ///The institution's site
        /// </summary>
        [DataMember(Name = "site")]
        public Sites_V6_0 Site { get; set; }

        /// <summary>
        /// The building at the selected site
        /// </summary>
        [DataMember(Name = "building")]
        public Buildings_V6_0 Building { get; set; }

        /// <summary>
        /// The period of time to be repeated
        /// </summary>
        [DataMember(Name = "recurrence")]
        public Recurrence3 Recurrence { get; set; }

        /// <summary>
        /// The type or style of a of room's layout, for example, \"Classroom\" style, \"Lecture Hall\" style, etc.  A room may support multiple types of layouts
        /// </summary>
        [DataMember(Name = "roomTypes")]
        public IEnumerable<RoomType> RoomType { get; set; }
    }
}
