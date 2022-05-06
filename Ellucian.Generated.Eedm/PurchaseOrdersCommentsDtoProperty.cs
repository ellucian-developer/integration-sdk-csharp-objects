//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The comments associated with the purchase order. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PurchaseOrdersCommentsDtoProperty
    {

        /// <summary>
        /// A comment associated with the purchase order.
        /// </summary>
        [JsonProperty("comment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// An indication of whether the comment is printed or not printed.
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CommentTypes? Type { get; set; }

    }
}