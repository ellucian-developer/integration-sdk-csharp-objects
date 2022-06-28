// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Valid statuses for section registration (required).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RegistrationStatus
    {
        /// <summary>
        /// A person is registered in the section.  The Registration status code is automatically assigned 
        /// in Colleague.  The Status Reason must be set to "Registered". 
        /// </summary>
        Registered,
        /// <summary>
        /// A person is not registered in the section.  A valid Status Reason must be assigned.
        /// </summary>
        [EnumMember(Value = "Not Registered")]
        NotRegistered 
    }
}
