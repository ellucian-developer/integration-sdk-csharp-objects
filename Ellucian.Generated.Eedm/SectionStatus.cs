// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Valid statuses for a section
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SectionStatus
    {
        /// <summary>
        /// Section is Closed - no further registration is allowed.
        /// </summary>
        Closed,
        /// <summary>
        /// Section is Open - registration for section is allowed.
        /// </summary>
        Open,
        /// <summary>
        /// Section is waiting for approval.
        /// </summary>
        Pending,
        /// <summary>
        /// Section has been cancelled.
        /// </summary>
        Cancelled
    }
}
