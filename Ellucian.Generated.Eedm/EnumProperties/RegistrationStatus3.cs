// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Valid statuses for section registration (required).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RegistrationStatus3
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// A person is registered in the section.  The Registration status code is automatically assigned 
        /// in Colleague.  The Status Reason must be set to "Registered". 
        /// </summary>
        [EnumMember(Value = "registered")]
        Registered,

        /// <summary>
        /// A person is not registered in the section.  A valid Status Reason must be assigned.
        /// </summary>
        [EnumMember(Value = "notRegistered")]
        NotRegistered 
    }
}
