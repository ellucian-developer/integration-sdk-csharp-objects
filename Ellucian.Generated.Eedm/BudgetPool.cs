// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The pool accounts associated with the accounting string component value by fiscal year.
    /// </summary>
    [DataContract]
    public class BudgetPool
    {
        /// <summary>
        /// The fiscal year associated with the budget pool.
        /// </summary>
        [JsonProperty("fiscalYear")]
        public GuidObject2 FiscalYear { get; set; }

        /// <summary>
        /// The pool account associated with the accounting string component value.
        /// </summary>
        [JsonProperty("accountingComponent")]
        public GuidObject2 AccountingComponent { get; set; }
    }
}