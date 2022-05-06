// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Indicates whether to include the registration of a section towards the head count.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HeadCountStatus
    {
        /// <summary>
        /// Default for when the enumeration is not set
        /// </summary>
        NotSet = 0,
        /// <summary>
        /// Publish "include" in this property where the corresponding status.registrationStatus is published as 'registered'.
        /// </summary>
        [EnumMember(Value = "include")]
        Include,
        /// <summary>
        /// Publish "exclude" in this property where the corresponding status.registrationStatus is published as 'notRegistered'.
        /// </summary>
        [EnumMember(Value = "exclude")]
        Exclude 
    }
}
