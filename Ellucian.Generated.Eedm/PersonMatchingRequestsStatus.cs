// Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The outcome status of the person matching request.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonMatchingRequestsStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// newPerson
        /// </summary>
        [EnumMember(Value = "newPerson")]
        NewPerson,

        /// <summary>
        /// secondary
        /// </summary>
        [EnumMember(Value = "existingPerson")]
        ExistingPerson,

        /// <summary>
        /// reviewRequired
        /// </summary>
        [EnumMember(Value = "reviewRequired")]
        ReviewRequired,

        /// <summary>
        /// rejectedRequest
        /// </summary>
        [EnumMember(Value = "rejectedRequest")]
        RejectedRequest
    }
}

