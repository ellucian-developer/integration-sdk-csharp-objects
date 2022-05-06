//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an address
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountingCodeCategoryType
    {
        /// <summary>
        /// Default
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Charge
        /// </summary>
        [EnumMember(Value = "charge")]
        Charge,

        /// <summary>
        /// Payment
        /// </summary>
        [EnumMember(Value = "payment")]
        Payment,

        /// <summary>
        /// DepositType
        /// </summary>
        [EnumMember(Value = "depositType")]
        DepositType,

        /// <summary>
        /// DistributionCode
        /// </summary>
        [EnumMember(Value = "distributionCode")]
        DistributionCode,

        /// <summary>
        /// AccountsReceivableType
        /// </summary>
        [EnumMember(Value = "accountsReceivableType")]
        AccountsReceivableType,

        /// <summary>
        /// AccountsReceivableCode
        /// </summary>
        [EnumMember(Value = "accountsReceivableCode")]
        AccountsReceivableCode
    }
}
