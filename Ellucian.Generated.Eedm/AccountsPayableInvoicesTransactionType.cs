// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The transaction type associated with the invoice. This information is required for international ACH transactions for NACHA.
    /// </summary>
    [JsonConverter(typeof (StringEnumConverter))]
    public enum AccountsPayableInvoicesTransactionType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// annuity
        /// </summary>
        [EnumMember(Value = "annuity")]
        Annuity,

        /// <summary>
        /// businessCommercial
        /// </summary>
        [EnumMember(Value = "businessCommercial")]
        BusinessCommercial,
        
        /// <summary>
        /// deposit
        /// </summary>
        [EnumMember(Value = "deposit")]
        Deposit,
        
        /// <summary>
        /// load
        /// </summary>
        [EnumMember(Value = "load")]
        Load,
        
        /// <summary>
        /// miscellaneous
        /// </summary>
        [EnumMember(Value = "miscellaneous")]
        Miscellaneous,
        
        /// <summary>
        /// mortgage
        /// </summary>
        [EnumMember(Value = "mortgage")]
        Mortgage,
        
        /// <summary>
        /// pension
        /// </summary>
        [EnumMember(Value = "pension")]
        Pension,
        
        /// <summary>
        /// rentLease
        /// </summary>
        [EnumMember(Value = "rentLease")]
        RentLease,
        
        /// <summary>
        /// salaryPayroll
        /// </summary>
        [EnumMember(Value = "salaryPayroll")]
        SalaryPayroll,
        
        /// <summary>
        /// tax
        /// </summary>
        [EnumMember(Value = "tax")]
        Tax
    }
}