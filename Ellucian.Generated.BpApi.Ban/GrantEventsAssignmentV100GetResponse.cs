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

namespace Ellucian.Generated.BpApi.Ban.GrantEventsAssignmentV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class GrantEventsAssignmentV100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("frrevng", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Frrevng>? Frrevng { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("frbevng", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Frbevng>? Frbevng { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("frbgrnt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Frbgrnt>? Frbgrnt { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Frrevng
    {
        /// <summary>
        /// Lineage reference object : FRREVNG_STATUS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StatusDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRREVNG_SEQ_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SeqNum { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("respUserIdDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RespUserIdDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRREVNG_DUE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dueDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DueDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRREVNG_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("displayTextInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisplayTextInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRREVNG_RESPONSIBLE_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("responsibleUserId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ResponsibleUserId { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Frbevng
    {
        /// <summary>
        /// Lineage reference object : FRBEVNG_FREQ_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("freqInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FreqInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("periodTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PeriodTo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBEVNG_EVNT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("evntCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EvntCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBEVNG_DATE_FROM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dateFrom", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateFrom { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBEVNG_NUM_OF_DAYS_REMINDER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("numOfDaysReminder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NumOfDaysReminder { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBEVNG_NUM_OF_DAYS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("numOfDays", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NumOfDays { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("respUserIdDef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RespUserIdDef { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("bfrmCodeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BfrmCodeDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBEVNG_BEG_DATE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begDateInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BegDateInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBEVNG_DATE_TO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dateTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateTo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBEVNG_ALTERNATE_EVNT_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alternateEvntDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AlternateEvntDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBEVNG_BFRM_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bfrmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BfrmCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("evntCodeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EvntCodeDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBEVNG_PMT_METHOD_TYPE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pmtMethodTypeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PmtMethodTypeInd { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Frbgrnt
    {
        /// <summary>
        /// Lineage reference object : FRBGRNT_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FRBGRNT_TITLE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Title { get; set; } = default!;

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