// Copyright 2016-2018 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details of an accounting string component. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountingStringComponentValues_V8_0 : BaseModel2
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
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Component { get; set; }

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
        [JsonProperty("transactionStatus")]
        [FilterProperty("criteria")]
        public AccountingTransactionStatus? TransactionStatus { get; set; }

        /// <summary>
        /// Type of the account component.
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public AccountingStringComponentValuesType Type { get; set; }

    }

    /// <summary>
    /// Type of the account component. 
    /// </summary>
    [JsonObject("type")]
    public class AccountingStringComponentValuesType
    {
        /// <summary>
        /// Type of the account component.  
        /// </summary>
        [JsonProperty("account")]
        [FilterProperty("criteria")]
        public AccountingTypeAccount? Account { get; set; }

        /// <summary>
        /// Type of fund of the account component.
        /// </summary>
        [JsonProperty("fund",DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string Fund { get; set; }
    }
}
