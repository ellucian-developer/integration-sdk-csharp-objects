// Copyright 2018 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of the Buyer status.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SectionWaitlistEligible
    {
        /// <summary>
        /// Eligible
        /// </summary>
        [EnumMember(Value = "eligible")]
        Eligible,

        /// <summary>
        /// Not Eligible
        /// </summary>
        [EnumMember(Value = "notEligible")]
        NotEligible,
    }
}
