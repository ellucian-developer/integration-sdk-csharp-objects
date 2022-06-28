// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type or style of a of Room's layout.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RoomLayoutType2
    {
        /// <summary>
        /// Banquet
        /// </summary>
        [EnumMember(Value = "banquet")]
        Banquet,

        /// <summary>
        /// Conference
        /// </summary>
        [EnumMember(Value = "conference")]
        Conference,

        /// <summary>
        /// Sports Event
        /// </summary>
        [EnumMember(Value = "sportsevent")]
        Sportsevent,

        /// <summary>
        /// Graduation Ceremony
        /// </summary>
        [EnumMember(Value = "graduationceremony")]
        Graduationceremony,

        /// <summary>
        /// Seminar
        /// </summary>
        [EnumMember(Value = "seminar")]
        Seminar,

        /// <summary>
        /// Board Meeting
        /// </summary>
        [EnumMember(Value = "boardmeeting")]
        Boardmeeting,

        /// <summary>
        /// Performance
        /// </summary>
        [EnumMember(Value = "performance")]
        Performance,

        /// <summary>
        /// Convention
        /// </summary>
        [EnumMember(Value = "convention")]
        Convention,

        /// <summary>
        /// Convocation
        /// </summary>
        [EnumMember(Value = "convocation")]
        Convocation,

        /// <summary>
        /// Press Meet
        /// </summary>
        [EnumMember(Value = "pressmeet")]
        Pressmeet,

        /// <summary>
        /// Workshops
        /// </summary>
        [EnumMember(Value = "workshops")]
        Workshops,

        /// <summary>
        /// Exam
        /// </summary>
        [EnumMember(Value = "exam")]
        Exam,

        /// <summary>
        /// Classroom
        /// </summary>
        [EnumMember(Value = "classroom")]
        Classroom,

        /// <summary>
        /// laboratory
        /// </summary>
        [EnumMember(Value = "laboratory")]
        Laboratory,

        /// <summary>
        /// Default
        /// </summary>
        [EnumMember(Value = "default")]
        Default
    }
}