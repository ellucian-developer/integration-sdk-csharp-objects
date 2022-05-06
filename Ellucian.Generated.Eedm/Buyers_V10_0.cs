// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Purchasing agents for an institution. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Buyers_V10_0 : BaseModel2
    {
        /// <summary>
        /// A code that may be used to identify the buyer.
        /// </summary>
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// The name or detail information of the buyer.
        /// </summary>
        [JsonProperty("buyer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public NamePersonDtoProperty Buyer { get; set; }

        /// <summary>
        /// The earliest date when the buyer is active.
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BuyerStatus Status { get; set; }

        /// <summary>
        /// The earliest date when the buyer is active.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The last date when the buyer was active.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// The phone number of the buyer.
        /// </summary>
        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BuyersPhone Phone { get; set; }

        /// <summary>
        /// The maximum amount of a purchase order to which a buyer may be assigned (i.e. LVPO - low value purchase order).
        /// </summary>
        [JsonProperty("purchasingLimit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PurchasingLimit PurchasingLimit { get; set; }

    }

    /// <summary>
    /// The Phone number of the Buyer.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class BuyersPhone
    {
        /// <summary>
        /// The Phone number of the buyer.
        /// </summary>
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// The Phone extension of the buyer.
        /// </summary>
        [JsonProperty("extension", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Extension { get; set; }
    }

    /// <summary>
    /// The maximum amount of a purchase order to which a buyer may be assigned (i.e. LVPO - low value purchase order)
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PurchasingLimit
    {
        /// <summary>
        /// The total limit for the buyer.
        /// </summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// The ISO 4217 currency code
        /// </summary>
        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Currency { get; set; }
    }
}
