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

namespace Ellucian.Generated.BpApi.Ban.CourseSectionInformation100PostResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CourseSectionInformation100PostResponse
    {
        [Newtonsoft.Json.JsonProperty("ssbsect", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Ssbsect>? Ssbsect { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("key_block", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Key_block>? Key_block { get; set; } = default!;

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
        /// Lineage reference object : SSBSECT_TOT_CREDIT_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totCreditHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotCreditHrs { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseBillHrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScbcrseBillHrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_TUIW_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tuiwInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TuiwInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("acctDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseContHrHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseContHrHigh { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_ENRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Enrl { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseBillHrLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseBillHrLow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SCHD_CODE, Lookup lineage reference object : scrschd,stvschd,scrschd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schdCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SESS_CODE, Lookup lineage reference object : stvsess
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sessCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SessCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseLabHrLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseLabHrLow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PREREQ_CHK_METHOD_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prereqChkMethodCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrereqChkMethodCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_REG_AUTH_ACTIVE_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("regAuthActiveCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RegAuthActiveCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_RESERVED_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reservedInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ReservedInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("longTitleInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LongTitleInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CAMP_CODE, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CampCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_LEC_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lecHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LecHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SSTS_CODE, Lookup lineage reference object : stvssts
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sstsCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SstsCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("commentInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CommentInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseLecHrHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseLecHrHigh { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseLabHrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScbcrseLabHrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CENSUS_ENRL_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("censusEnrlDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CensusEnrlDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_INTG_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intgCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IntgCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_NUMBER_OF_EXTENSIONS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("numberOfExtensions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NumberOfExtensions { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_LEARNER_REGSTART_TDATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("learnerRegstartTdate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LearnerRegstartTdate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvgmodDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvgmodDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("wch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Wch { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("SectAuthStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SectAuthStartDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_GRADABLE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gradableInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GradableInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvsessDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvsessDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("xlstGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? XlstGroup { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SUBJ_CODE, Lookup lineage reference object : stvsubj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subjCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SubjCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_LEARNER_REGSTART_FDATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("learnerRegstartFdate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LearnerRegstartFdate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssrseatReg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SsrseatReg { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SEATS_AVAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seatsAvail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SeatsAvail { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CRSE_NUMB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crseNumb", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CrseNumb { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseCreditHrHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseCreditHrHigh { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PTRM_CODE, Lookup lineage reference object : sobptrm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PtrmCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SAPR_CODE, Lookup lineage reference object : stvsapr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("saprCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SaprCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseLabHrHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseLabHrHigh { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_OVERRIDE_DUR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("overrideDurInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OverrideDurInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_WAIT_AVAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waitAvail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WaitAvail { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_SEQ_NUMB
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNumb", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeqNumb { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ceuInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CeuInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseOthHrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScbcrseOthHrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CENSUS_2_ENRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("census2Enrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Census2Enrl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_DUNT_CODE, Lookup lineage reference object : gtvdunt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duntCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DuntCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseOthHrLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseOthHrLow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CREDIT_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creditHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CreditHrs { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseOthHrHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseOthHrHigh { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("SectStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SectStartDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("dch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Dch { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PROJ_ENRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("projEnrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ProjEnrl { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("subjDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SubjDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseContHrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScbcrseContHrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CENSUS_2_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("census2Date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Census2Date { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("gtvduntDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GtvduntDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Title { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvsstsDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvsstsDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvcampDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvcampDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssrseatPending", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SsrseatPending { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvsaprDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvsaprDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("gorintgDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GorintgDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_REG_FROM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("regFromDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RegFromDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_BILL_HRS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billHrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BillHrs { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_VOICE_AVAIL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voiceAvail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VoiceAvail { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("syllabusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SyllabusInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseCreditHrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScbcrseCreditHrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CAPP_PREREQ_TEST_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cappPrereqTestInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CappPrereqTestInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("SectWLNotificationEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SectWLNotificationEndDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseContHrLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseContHrLow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_OTH_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("othHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OthHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PTRM_START_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PtrmStartDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseLecHrLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseLecHrLow { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CONT_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_GMOD_CODE, Lookup lineage reference object : stvgmod,scrgmod,scrgmod
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gmodCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GmodCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_WAIT_CAPACITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waitCapacity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double WaitCapacity { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseBillHrHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseBillHrHigh { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("gtvinsmDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? GtvinsmDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_LINK_IDENT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("linkIdent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LinkIdent { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_LAB_HR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("labHr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LabHr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_INSM_CODE, Lookup lineage reference object : gtvinsm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insmCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InsmCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("stvschdDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StvschdDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_ACCT_CODE, Lookup lineage reference object : stvacct
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AcctCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseCreditHrLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ScbcrseCreditHrLow { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("scbcrseLecHrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ScbcrseLecHrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_MAX_ENRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxEnrl", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double MaxEnrl { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssrseawPending", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SsrseawPending { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PRNT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prntInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PrntInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_NUMBER_OF_UNITS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("numberOfUnits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NumberOfUnits { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("ssrseawWaitlist", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SsrseawWaitlist { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PTRM_WEEKS
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmWeeks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtrmWeeks { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_REG_TO_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("regToDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RegToDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_CENSUS_ENRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("censusEnrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CensusEnrl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PTRM_END_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ptrmEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PtrmEndDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_PRIOR_ENRL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priorEnrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriorEnrl { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SSBSECT_WAIT_COUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waitCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WaitCount { get; set; } = default!;

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
        /// Lineage reference object : ssasectTermCode, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssasectTermCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsasectTermCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : ssasectCrn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssasectCrn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SsasectCrn { get; set; } = default!;

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