// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// The type of activity.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LedgerActivityType
    {     
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
       
                           
         /// <summary>
        /// credit
        /// </summary>
        [EnumMember(Value = "credit")]
        Credit,
                     
         /// <summary>
        /// debit
        /// </summary>
        [EnumMember(Value = "debit")]
        Debit,
        }
} 


