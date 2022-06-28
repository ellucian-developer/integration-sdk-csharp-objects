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

namespace Ellucian.Generated.BpApi.Ban.QuickAdmitStudents100PostRequest
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class QuickAdmitStudents100PostRequest
    {
        /// <summary>
        /// Lineage reference object : SPRADDR_STREET_LINE2
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetLine2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_CNTY_CODE, Lookup lineage reference object : stvcnty
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cntyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CntyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_MRTL_CODE, Lookup lineage reference object : stvmrtl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mrtlCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MrtlCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STREET_LINE1
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetLine1 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_CORRECTION_DIGIT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spraddrCorrectionDigit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SpraddrCorrectionDigit { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_KEY_SEQNO, Lookup lineage reference object : sgvstsp,sgrstsp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorlcurKeyNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SorlcurKeyNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLFOS_MAJR_CODE, Lookup lineage reference object : stvmajr,sovlfos
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorlfosMajrCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SorlfosMajrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STREET_LINE3
        /// </summary>
        [Newtonsoft.Json.JsonProperty("streetLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StreetLine3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_VERA_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("veraInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VeraInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_SSN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ssn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Ssn { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_ACTIVE_DUTY_SEPR_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activeDutySeprDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ActiveDutySeprDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_DEAD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deadInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeadInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STATUS_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatusInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_LEVL_CODE, Lookup lineage reference object : stvlevl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorlcurLevlCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SorlcurLevlCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("persSex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PersSex { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_ZIP
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Zip { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_DELIVERY_POINT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliveryPoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DeliveryPoint { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_COLL_CODE, Lookup lineage reference object : stvcoll
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorlcurCollCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SorlcurCollCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_PRIORITY_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorlcurPriorityNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SorlcurPriorityNo { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addAdmInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddAdmInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_RESD_CODE, Lookup lineage reference object : stvresd
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resdCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ResdCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_ASRC_CODE, Lookup lineage reference object : stvasrc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asrcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AsrcCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvadmt
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stdadapAdmtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StdadapAdmtCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_CONFID_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confidInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConfidInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_FROM_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fromDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FromDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("phoneNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_STST_CODE, Lookup lineage reference object : stvstst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ststCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_CITZ_CODE, Lookup lineage reference object : stvcitz
        /// </summary>
        [Newtonsoft.Json.JsonProperty("citzCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CitzCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvapdc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stdappdApdcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StdappdApdcCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("phoneArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneArea { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_TERM_CODE_CTLG, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorlcurTerCodeCtlg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SorlcurTerCodeCtlg { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_SDVET_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sdvetInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SdvetInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : GORPRAC_RACE_CDE, Lookup lineage reference object : gorrace
        /// </summary>
        [Newtonsoft.Json.JsonProperty("raceCde", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RaceCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocLevlCode, Lookup lineage reference object : stvlevl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("levlCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LevlCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_DEAD_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deadDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DeadDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_CITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? City { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_EDLV_CODE, Lookup lineage reference object : stvedlv
        /// </summary>
        [Newtonsoft.Json.JsonProperty("edlvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EdlvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_DEGC_CODE, Lookup lineage reference object : stvdegc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorlcurDegcCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SorlcurDegcCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_CARRIER_ROUTE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("carrierRoute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CarrierRoute { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_RELG_CODE, Lookup lineage reference object : stvrelg
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relgCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RelgCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_ETHN_CODE, Lookup lineage reference object : stvethn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ethnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EthnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_RATE_CODE, Lookup lineage reference object : stvrate
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rateCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RateCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_ETHN_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ethnCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EthnCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_FULL_PART_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fullPartInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FullPartInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("phoneExt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? PhoneExt { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_CONFIRMED_RE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confirmedReDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ConfirmedReDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_STAT_CODE, Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_NATN_CODE, Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("natnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NatnCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvsbgi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stdrecrSbgiCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StdrecrSbgiCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLFOS_DEPT_CODE, Lookup lineage reference object : stvdept
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorlfosDeptCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SorlfosDeptCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_TO_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ToDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_LGCY_CODE, Lookup lineage reference object : stvlgcy
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lgcyCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? LgcyCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_ARMED_SERV_MED_VET_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("armedServMedVetInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ArmedServMedVetInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLFOS_CSTS_CODE, Lookup lineage reference object : stvcsts
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorlfosCstsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SorlfosCstsCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_BIRTH_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("birthDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BirthDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_CAMP_CODE, Lookup lineage reference object : stvcamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorlcurCampCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SorlcurCampCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvtele
        /// </summary>
        [Newtonsoft.Json.JsonProperty("teleCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TeleCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLFOS_LFST_CODE, Lookup lineage reference object : gtvlfst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorlfosLfstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SorlfosLfstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_VETC_FILE_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vetcFileNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VetcFileNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLFOS_PRIORITY_NO
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorlfosPriorityNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SorlfosPriorityNo { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_EGOL_CODE, Lookup lineage reference object : stvegol
        /// </summary>
        [Newtonsoft.Json.JsonProperty("egolCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EgolCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addRecrInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddRecrInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SOVLCUR_PROGRAM, Lookup lineage reference object : smrprle
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sorlcurProgram", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SorlcurProgram { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SGBSTDN_STYP_CODE, Lookup lineage reference object : stvstyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StypCode { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvapst
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stdadapApstCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StdadapApstCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPBPERS_CONFIRMED_RE_CDE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confirmedReCde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ConfirmedReCde { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : SPRADDR_ATYP_CODE, Lookup lineage reference object : stvatyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AtypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : keyblocTermCode, Lookup lineage reference object : stvterm
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