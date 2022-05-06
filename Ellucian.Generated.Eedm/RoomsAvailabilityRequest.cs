// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Request for room availability for a given date range, window of time, and interval
    /// </summary>
    [DataContract]
    public class RoomsAvailabilityRequest
    {

        /// <summary>
        /// The global identifier of the institution's site
        /// </summary>
       [DataMember(Name = "site")]
        public string Site { get; set; }

        /// <summary>
       /// The global identifier of a building
        /// </summary>
        [DataMember(Name = "building")]
       public string Building { get; set; }
        
        /// <summary>
        /// The starting date at which a room must have availability
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The ending date through which a room must have availability
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The starting time at which a room must have availability for a given day
        /// </summary>
        [DataMember(Name = "startTime")]
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// The ending time through which a room must have availability for a given day
        /// </summary>
        [DataMember(Name = "endTime")]
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// A specification for how to calculate a recurring event.
        /// </summary>
        [DataMember(Name = "recurrence")]
        public Recurrence RecurrencePattern { get; set; }

        /// <summary>
        /// The maximum number of persons who may occupy a Room arranged in a given layout.
        /// </summary>
        [DataMember(Name = "occupancies")]
        public IEnumerable<Occupancy> Occupancies { get; set; }
    }
}
