// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// The type of the employment frequency.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EmploymentFrequenciesType
    {     
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
       
                           
         /// <summary>
        /// daily
        /// </summary>
        [EnumMember(Value = "daily")]
        Daily,
                     
         /// <summary>
        /// weekly
        /// </summary>
        [EnumMember(Value = "weekly")]
        Weekly,
                     
         /// <summary>
        /// biWeekly
        /// </summary>
        [EnumMember(Value = "biWeekly")]
        Biweekly,
                     
         /// <summary>
        /// monthly
        /// </summary>
        [EnumMember(Value = "monthly")]
        Monthly,
                     
         /// <summary>
        /// quarterly
        /// </summary>
        [EnumMember(Value = "quarterly")]
        Quarterly,
                     
         /// <summary>
        /// annually
        /// </summary>
        [EnumMember(Value = "annually")]
        Annually,
                     
         /// <summary>
        /// semimonthly
        /// </summary>
        [EnumMember(Value = "semimonthly")]
        Semimonthly,

        /// <summary>
        /// semiannually
        /// </summary>
        [EnumMember(Value = "semiannually")]
        Semiannually,

         /// <summary>
        /// contractual
        /// </summary>
        [EnumMember(Value = "contractual")]
        Contractual,
        }
} 


