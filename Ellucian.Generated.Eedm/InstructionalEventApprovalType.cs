using System.Runtime.Serialization;
// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Validation rule types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstructionalEventApprovalType
    {
        /// <summary>
        /// Instructor Availability
        /// </summary>
        [EnumMember(Value = "Instructor Availability")]
        InstructorAvailability,

        /// <summary>
        /// Instructor Capacity
        /// </summary>
        [EnumMember(Value = "Instructor Capacity")]
        InstructorCapacity,

        /// <summary>
        /// Room Availability
        /// </summary>
        [EnumMember(Value = "Room Availability")]
        RoomAvailability,

        /// <summary>
        /// Room Capacity
        /// </summary>
        [EnumMember(Value = "Room Capacity")]
        RoomCapacity
    }
}
