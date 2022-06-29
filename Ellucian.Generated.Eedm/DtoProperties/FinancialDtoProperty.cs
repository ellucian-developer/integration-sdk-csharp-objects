// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The amount and currency values for a general ledger transaction
    /// </summary>
    [DataContract]
    public class FinancialDtoProperty
    {
        /// <summary>
        /// The monetary value for the specified currency.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// The ISO 4217 currency code
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public CurrencyCodes? Currency { get; set; }
    }
}