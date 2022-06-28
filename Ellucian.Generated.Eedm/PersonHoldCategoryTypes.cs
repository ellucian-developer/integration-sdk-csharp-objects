using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Person hold category types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonHoldCategoryTypes
    {
        /// <summary>
        /// Academic
        /// </summary>
        [EnumMember(Value = "academic")]
        Academic,
        /// <summary>
        /// Administrative
        /// </summary>
        [EnumMember(Value = "administrative")]
        Administrative,
        /// <summary>
        /// Disciplinary
        /// </summary>
        [EnumMember(Value = "disciplinary")]
        Disciplinary,
        /// <summary>
        /// Financial
        /// </summary>
        [EnumMember(Value = "financial")]
        Financial,
        /// <summary>
        /// Health
        /// </summary>
        [EnumMember(Value = "health")]
        Health
    }
}