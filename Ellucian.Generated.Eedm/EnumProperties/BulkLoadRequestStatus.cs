// Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Job Status
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BulkLoadRequestStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// inProgress
        /// </summary>
        [EnumMember(Value = "inProgress")]
        InProgress,

        /// <summary>
        /// completed
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed,

        /// <summary>
        /// packagingCompleted
        /// </summary>
        [EnumMember(Value = "packagingCompleted")]
        PackagingCompleted,

        /// <summary>
        /// error
        /// </summary>
        [EnumMember(Value = "error")]
        Error
    }
}