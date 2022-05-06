using Ellucian.Generated.Eedm.Attributes;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details of an accounting string component. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountingStringComponentValues_V15_0 : BaseModel2
    {
        /// <summary>
        /// The value of the accounting string component.
        /// </summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// The description of the accounting string component value.
        /// </summary>
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Accounting string component used in the accounting string.
        /// </summary>
        [JsonProperty("component")]
        [FilterProperty("criteria")]
        public GuidObject2 Component { get; set; }

        /// <summary>
        /// Accounting string sub component used in the accounting string.
        /// </summary>
        [JsonProperty("subcomponents", DefaultValueHandling = DefaultValueHandling.Ignore)]        
        public IEnumerable<GuidObject2> SubComponents { get; set; }

        /// <summary>
        /// The accounting string component identifying a relationship with a prerequisite domain component.
        /// </summary>
        [JsonProperty("determiningComponent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 DeterminingComponent { get; set; }

        /// <summary>
        /// The default accounting string component values related to this component value
        /// </summary>
        [JsonProperty("relatedComponentDefaults", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> RelatedComponentDefaults { get; set; }

        /// <summary>
        /// The accounting string component that is one level higher in the component hierarchy.
        /// </summary>
        [JsonProperty("parentComponent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ParentComponent { get; set; }

        /// <summary>
        /// Indicates if accounting string component value is available for transaction entry.
        /// </summary>
        [JsonProperty("transactionStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public AccountingTransactionStatus? TransactionStatus { get; set; }

        /// <summary>
        /// Type of the account component.
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public AccountingStringComponentValuesType Type { get; set; }

        /// <summary>
        /// The pool accounts associated with the accounting string component value by fiscal year.
        /// </summary>
        [JsonProperty("budgetPools", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<BudgetPool> BudgetPools { get; set; }

        /// <summary>
        /// The first date and time that the version of the accounting string component value is effective.
        /// </summary>
        [JsonProperty("effectiveStartOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EffectiveStartOn { get; set; }

        /// <summary>
        /// The last date and time that the version of the accounting string component value is effective.
        /// </summary>
        [JsonProperty("effectiveEndOn", DefaultValueHandling = DefaultValueHandling.Ignore)]    
        public DateTime? EffectiveEndOn { get; set; }

        /// <summary>
        /// The status of the accounting string component value (active or inactive).
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public Status Status { get; set; }

        /// <summary>
        /// Accounting string sub component used in the accounting string.
        /// </summary>
        [JsonProperty("grants", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public IEnumerable<GuidObject2> Grants { get; set; }
    }
}
