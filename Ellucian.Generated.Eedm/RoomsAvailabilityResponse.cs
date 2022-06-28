// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Room availability for a given availability request
    /// </summary>
    [DataContract]
    public class RoomsAvailabilityResponse
    {
        /// <summary>
        /// Collection of parts or divisions of a building enclosed by walls, floor, and ceiling.
        /// </summary>
        [DataMember(Name = "rooms")]
        public IEnumerable<Room> Rooms { get; set; }
    }
}
