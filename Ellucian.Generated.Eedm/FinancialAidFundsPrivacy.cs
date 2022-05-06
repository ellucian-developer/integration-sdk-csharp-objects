// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// The privacy level of the financial aid fund based on privacy concerns (restricted, non-restricted). This indicates whether the award of this fund to a student is restricted or not for view.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidFundsPrivacy
    {     
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
       
                           
         /// <summary>
        /// restricted
        /// </summary>
        [EnumMember(Value = "restricted")]
        Restricted,
                     
         /// <summary>
        /// nonRestricted
        /// </summary>
        [EnumMember(Value = "nonRestricted")]
        Nonrestricted,
        }
} 


