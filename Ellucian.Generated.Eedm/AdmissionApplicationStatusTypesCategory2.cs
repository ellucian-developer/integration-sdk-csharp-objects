// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The top level category of the admission application status type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdmissionApplicationStatusTypesCategory2
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// applied
        /// </summary>
        [EnumMember(Value = "applied")]
        Applied,

        /// <summary>
        /// complete
        /// </summary>
        [EnumMember(Value = "complete")]
        Complete,

        /// <summary>
        /// accepted
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted,

        /// <summary>
        /// waitlisted
        /// </summary>
        [EnumMember(Value = "waitlisted")]
        Waitlisted,

        /// <summary>
        /// rejected
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected,

        /// <summary>
        /// movedToStudent
        /// </summary>
        [EnumMember(Value = "movedToStudent")]
        MovedToStudent,

        /// <summary>
        /// withdrawn
        /// </summary>
        [EnumMember(Value = "withdrawn")]
        Withdrawn,
    }
}


