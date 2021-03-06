//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#nullable enable

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"

namespace Ellucian.Generated.BpApi.Ban.CommentBillingMassDataEntry100PostResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CommentBillingMassDataEntry100PostResponse
    {
        [Newtonsoft.Json.JsonProperty("key_block", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Key_block>? Key_block { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbrcmnt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbrcmnt>? Tbrcmnt { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Key_block
    {
        /// <summary>
        /// Lineage reference object : keyblocOrigCode, Lookup lineage reference object : stvorig
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocOrigCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocOrigCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocComment
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocComment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? KeyblocComment { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocTermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocTextCode
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocTextCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocTextCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocPurgeInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocPurgeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocPurgeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocCommentCode, Lookup lineage reference object : ttvcmnt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocCommentCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocCommentCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocEnddate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocEnddate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? KeyblocEnddate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocRestrictUpdateInd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyblocRestrictUpdateInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? KeyblocRestrictUpdateInd { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tbrcmnt
    {
        /// <summary>
        /// Lineage reference object : TBRCMNT_ENDDATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enddate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Enddate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRCMNT_COMMENT_CODE, Lookup lineage reference object : ttvcmnt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commentCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CommentCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Name { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRCMNT_RESTRICT_UPDATE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("restrictUpdateInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RestrictUpdateInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRCMNT_PURGE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("purgeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PurgeInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRCMNT_ORIG_CODE, Lookup lineage reference object : stvorig
        /// </summary>
        [Newtonsoft.Json.JsonProperty("origCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OrigCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRCMNT_TERM_CODE, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TermCode { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603