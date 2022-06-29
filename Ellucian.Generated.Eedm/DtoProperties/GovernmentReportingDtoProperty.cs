// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information required for government reporting.
    /// </summary>
    [DataContract]
    public class GovernmentReportingDtoProperty
    {
        /// <summary>
        /// The country code of the United States of America
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CountryCodeType? Code { get; set; }
      
        /// <summary>
        /// The transaction type associated with the invoice. This information is required for international ACH transactions for NACHA.
        /// </summary>
        [DataMember(Name = "transactionType", EmitDefaultValue = false)]
        public AccountsPayableInvoicesTransactionType? TransactionType { get; set; }
    }
}