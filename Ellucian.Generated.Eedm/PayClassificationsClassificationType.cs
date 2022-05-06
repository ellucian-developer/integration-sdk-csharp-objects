// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// The type of pay classification (e.g. matrix or range).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PayClassificationsClassificationType
    {     
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
                           
         /// <summary>
        /// matrix
        /// </summary>
        [EnumMember(Value = "matrix")]
        Matrix,
                     
         /// <summary>
        /// range
        /// </summary>
        [EnumMember(Value = "range")]
        Range,
    }
} 


