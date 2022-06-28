// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// Type of the financial aid fund (loan, grant, scholarship, work).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidFundsAidType
    {     
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
       
                           
         /// <summary>
        /// loan
        /// </summary>
        [EnumMember(Value = "loan")]
        Loan,
                     
         /// <summary>
        /// grant
        /// </summary>
        [EnumMember(Value = "grant")]
        Grant,
                     
         /// <summary>
        /// scholarship
        /// </summary>
        [EnumMember(Value = "scholarship")]
        Scholarship,
                     
         /// <summary>
        /// work
        /// </summary>
        [EnumMember(Value = "work")]
        Work,
        }
} 


