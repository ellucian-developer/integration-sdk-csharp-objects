// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Valid statuses for a section
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SectionStatus2
    {
        /// <summary>
        /// Not Set
        /// </summary>
        NotSet,

        /// <summary>
        /// Section is Closed - no further registration is allowed.
        /// </summary>
        [EnumMember(Value = "closed")]
        Closed,
        /// <summary>
        /// Section is Open - registration for section is allowed.
        /// </summary>
        [EnumMember(Value = "open")]
        Open,
        /// <summary>
        /// Section is waiting for approval.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>
        /// Section has been cancelled.
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled
    }
}
