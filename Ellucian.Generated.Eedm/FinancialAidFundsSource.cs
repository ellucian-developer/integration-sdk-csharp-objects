// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// The source of the financial aid fund (federal, state, institutional, other).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidFundsSource
    {     
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
       
                           
         /// <summary>
        /// federal
        /// </summary>
        [EnumMember(Value = "federal")]
        Federal,
                     
         /// <summary>
        /// institutional
        /// </summary>
        [EnumMember(Value = "institutional")]
        Institutional,
                     
         /// <summary>
        /// state
        /// </summary>
        [EnumMember(Value = "state")]
        State,
                     
         /// <summary>
        /// other
        /// </summary>
        [EnumMember(Value = "other")]
        Other,
        }
} 


