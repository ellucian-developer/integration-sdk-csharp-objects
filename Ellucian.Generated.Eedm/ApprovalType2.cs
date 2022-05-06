// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The approval type for registration
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApprovalType2
    {
        /// <summary>
        /// Approve All.  All verifications have already been evaluated and the registration
        /// </summary>
        /// 
        [EnumMember(Value = "all")]
        All
    }
}