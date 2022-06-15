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

namespace Ellucian.Generated.BpApi.Ban.ElectronicGradeBookConfigurationV100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ElectronicGradeBookConfigurationV100PutResponse
    {
        [Newtonsoft.Json.JsonProperty("sobptrm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sobptrm>? Sobptrm { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("sobterm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sobterm>? Sobterm { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssbssec", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ssbssec>? Ssbssec { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssbsect", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ssbsect>? Ssbsect { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("shbgctl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Shbgctl>? Shbgctl { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sobptrm
    {
        /// <summary>
        /// Lineage reference object : SOBPTRM_REAS_GRDE_PUB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasGrdePubDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReasGrdePubDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_SCORE_OPEN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scoreOpenDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ScoreOpenDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_PTRM_CODE, Lookup lineage reference object : SOBPTRM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PtrmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_REAS_SCORE_OPEN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasScoreOpenDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReasScoreOpenDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_DET_GRDE_PUB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detGrdePubDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DetGrdePubDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_FINAL_GRDE_PUB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finalGrdePubDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FinalGrdePubDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_SCORE_CUTOFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scoreCutoffDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ScoreCutoffDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_DESC, Lookup lineage reference object : SOBPTRM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Desc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_REAS_DET_GRDE_PUB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasDetGrdePubDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReasDetGrdePubDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBPTRM_REAS_SCORE_CUTOFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasScoreCutoffDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReasScoreCutoffDate { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sobterm
    {
        /// <summary>
        /// Lineage reference object : SOBTERM_REAS_GRDE_PUB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasGrdePubDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReasGrdePubDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBTERM_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBTERM_DET_GRDE_PUB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detGrdePubDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DetGrdePubDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBTERM_FINAL_GRDE_PUB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finalGrdePubDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FinalGrdePubDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBTERM_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOBTERM_REAS_DET_GRD_PB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasDetGrdPbDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReasDetGrdPbDate { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ssbssec
    {
        /// <summary>
        /// Lineage reference object : SSBSSEC_REAS_GRDE_PUB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasGrdePubDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReasGrdePubDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSSEC_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSSEC_DET_GRDE_PUB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detGrdePubDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DetGrdePubDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSSEC_FINAL_GRDE_PUB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finalGrdePubDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FinalGrdePubDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSSEC_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSSEC_REAS_DET_GRDE_PUB_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasDetGrdePubDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReasDetGrdePubDate { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Ssbsect
    {
        /// <summary>
        /// Lineage reference object : SSBSECT_SCORE_OPEN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scoreOpenDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ScoreOpenDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_REAS_SCORE_OPEN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasScoreOpenDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReasScoreOpenDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_REAS_SCORE_CTOF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasScoreCtofDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReasScoreCtofDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SCORE_CUTOFF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scoreCutoffDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ScoreCutoffDate { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Shbgctl
    {
        /// <summary>
        /// Lookup lineage reference object : shbgrul
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CompResitRuleDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompResitRuleDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBGCTL_COMP_LATE_RULE, Lookup lineage reference object : shbgrul
        /// </summary>
        [Newtonsoft.Json.JsonProperty("compLateRule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompLateRule { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBGCTL_COMP_RESIT_RULE, Lookup lineage reference object : shbgrul
        /// </summary>
        [Newtonsoft.Json.JsonProperty("compResitRule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompResitRule { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBGCTL_SCORE_OPEN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scoreOpenDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ScoreOpenDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBGCTL_REAS_SCORE_OPEN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasScoreOpenDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReasScoreOpenDate { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : shbgrul
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subLateRuleDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubLateRuleDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBGCTL_REAS_SCORE_CTOF_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasScoreCtofDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ReasScoreCtofDate { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : shbgrul
        /// </summary>
        [Newtonsoft.Json.JsonProperty("compLateRuleDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompLateRuleDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBGCTL_USER_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? UserId { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : shbgrul
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subResitRuleDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubResitRuleDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBGCTL_SUB_RESIT_RULE, Lookup lineage reference object : shbgrul
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subResitRule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubResitRule { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBGCTL_ACTIVITY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activityDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActivityDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBGCTL_FIN_SCORE_CUTOFF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finScoreCutoff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FinScoreCutoff { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBGCTL_MID_SCORE_CUTOFF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("midScoreCutoff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? MidScoreCutoff { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SHBGCTL_SUB_LATE_RULE, Lookup lineage reference object : shbgrul
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subLateRule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubLateRule { get; set; } = default!;

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