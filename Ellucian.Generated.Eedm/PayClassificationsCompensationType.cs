// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// The compensation type associated with the pay classification (e.g. salary or wages).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PayClassificationsCompensationType
    {     
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
                           
         /// <summary>
        /// wages
        /// </summary>
        [EnumMember(Value = "wages")]
        Wages,
                     
         /// <summary>
        /// salary
        /// </summary>
        [EnumMember(Value = "salary")]
        Salary,
    }
} 


