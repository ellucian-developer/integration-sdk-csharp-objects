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

namespace Ellucian.Generated.BpApi.Ban.ThirdPartyRegistrationTimeControls100PostResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ThirdPartyRegistrationTimeControls100PostResponse
    {
        /// <summary>
        /// Lineage reference object : SFRCTRL_LEVL_2, Lookup lineage reference object : stvlevl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("levl2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Levl2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_LEVL_1, Lookup lineage reference object : stvlevl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("levl1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Levl1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_LEVL_4, Lookup lineage reference object : stvlevl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("levl4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Levl4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_SEQ_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double SeqNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_LEVL_3, Lookup lineage reference object : stvlevl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("levl3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Levl3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_LEVL_5, Lookup lineage reference object : stvlevl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("levl5", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Levl5 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_COLL_INCL_EXCL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collInclExcl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollInclExcl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_LAST_NAM_END
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastNamEnd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LastNamEnd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_STUD_TYPE_2, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("studType2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StudType2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_MAJR_INCL_EXCL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majrInclExcl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MajrInclExcl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_STUD_TYPE_3, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("studType3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StudType3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_STUD_TYPE_4, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("studType4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StudType4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_STUD_TYPE_5, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("studType5", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StudType5 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_EARN_HRS_END
        /// </summary>
        [Newtonsoft.Json.JsonProperty("earnHrsEnd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? EarnHrsEnd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_STUD_TYPE_1, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("studType1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StudType1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_PIN_END
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pinEnd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PinEnd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_DEPT_5, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dept5", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Dept5 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_PIN_START
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pinStart", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PinStart { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_HOUR_BEGIN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hourBegin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HourBegin { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_LAST_NAM_START
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastNamStart", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LastNamStart { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_DEGR_1, Lookup lineage reference object : stvdegc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degr1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Degr1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_DEGR_2, Lookup lineage reference object : stvdegc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degr2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Degr2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_DEGR_3, Lookup lineage reference object : stvdegc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degr3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Degr3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_DEGR_4, Lookup lineage reference object : stvdegc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degr4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Degr4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_DEGR_5, Lookup lineage reference object : stvdegc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degr5", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Degr5 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_EARN_HRS_BEGIN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("earnHrsBegin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? EarnHrsBegin { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_DEPT_1, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dept1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Dept1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_DEPT_2, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dept2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Dept2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_DEPT_3, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dept3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Dept3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_DEPT_4, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dept4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Dept4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_CMPS_3, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cmps3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Cmps3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_HOUR_END
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hourEnd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HourEnd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_CMPS_4, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cmps4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Cmps4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_CMPS_1, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cmps1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Cmps1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_CMPS_2, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cmps2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Cmps2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_CLS_INCL_EXCL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clsInclExcl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ClsInclExcl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_DEPT_INCL_EXCL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deptInclExcl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeptInclExcl { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvtermDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvtermDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_CMPS_5, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cmps5", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Cmps5 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_CMPS_INCL_EXCL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cmpsInclExcl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CmpsInclExcl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_DEGR_INCL_EXCL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("degrInclExcl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DegrInclExcl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_COLL_3, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coll3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Coll3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_COLL_2, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coll2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Coll2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_COLL_1, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coll1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Coll1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_CLS_4, Lookup lineage reference object : stvclas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cls4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Cls4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_CLS_5, Lookup lineage reference object : stvclas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cls5", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Cls5 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_CLS_2, Lookup lineage reference object : stvclas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cls2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Cls2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_CLS_3, Lookup lineage reference object : stvclas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cls3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Cls3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_TERM_CODE_HOST, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCodeHost", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TermCodeHost { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_CLS_1, Lookup lineage reference object : stvclas
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cls1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Cls1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_COLL_5, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coll5", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Coll5 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_COLL_4, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coll4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Coll4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_BEGIN_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beginDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BeginDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_MAJR_5, Lookup lineage reference object : stvmajr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majr5", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Majr5 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_MAJR_4, Lookup lineage reference object : stvmajr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majr4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Majr4 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_MAJR_1, Lookup lineage reference object : stvmajr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majr1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Majr1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_MAJR_3, Lookup lineage reference object : stvmajr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majr3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Majr3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SFRCTRL_MAJR_2, Lookup lineage reference object : stvmajr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("majr2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Majr2 { get; set; } = default!;

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