// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Validation rule types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstructionalEventApprovalType2
    {
        /// <summary>
        /// Instructor Availability
        /// </summary>
        [EnumMember(Value = "instructor availability")]
        InstructorAvailability,

        /// <summary>
        /// Instructor Capacity
        /// </summary>
        [EnumMember(Value = "instructor capacity")]
        InstructorCapacity,

        /// <summary>
        /// Room Availability
        /// </summary>
        [EnumMember(Value = "room availability")]
        RoomAvailability,

        /// <summary>
        /// Room Capacity
        /// </summary>
        [EnumMember(Value = "room capacity")]
        RoomCapacity
    }
}
