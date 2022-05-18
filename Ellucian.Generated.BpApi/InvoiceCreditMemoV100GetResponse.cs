//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
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

namespace Ellucian.Generated.BpApi.Ban.InvoiceCreditMemoV100GetResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class InvoiceCreditMemoV100GetResponse
    {
        [Newtonsoft.Json.JsonProperty("natnDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NatnDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_ATYP_SEQ_NUM_VEND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypSeqNumVend", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AtypSeqNumVend { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_CURR_CODE, Lookup lineage reference object : gtvcurr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_DISB_AGENT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disbAgentInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DisbAgentInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_TGRP_CODE, Lookup lineage reference object : ftvtrat,ftvtgrp,ftrtgtr,ftvtgrp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tgrpCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TgrpCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("headerText", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HeaderText { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("collectsTaxes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollectsTaxes { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("directDepositStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DirectDepositStatus { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("page2City", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Page2City { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("checkVendorMarker", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CheckVendorMarker { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_VEND_HOLD_OVRD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendHoldOvrdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendHoldOvrdInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_APPR_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apprInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ApprInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_DISC_CODE, Lookup lineage reference object : ftvdisc
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DiscCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_SINGLE_ACCTG_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("singleAcctgInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SingleAcctgInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("page2VendAddr3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Page2VendAddr3 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_COMPLETE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("completeInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CompleteInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("page2VendAddr1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Page2VendAddr1 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("page2VendAddr2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Page2VendAddr2 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_NSF_ON_OFF_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nsfOnOffInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? NsfOnOffInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_CORRECTION_DIGIT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("correctionDigit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CorrectionDigit { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("zip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Zip { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_DELIVERY_POINT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliveryPoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DeliveryPoint { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("collectsTaxesTitle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CollectsTaxesTitle { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_RUIV_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruivInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RuivInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_VEND_INV_CODE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendInvCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendInvCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_1099_ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("1099Id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? _1099Id { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_RUIV_INSTALLMENT_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruivInstallmentInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RuivInstallmentInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("page2NsfSuspInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Page2NsfSuspInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_GROUPING_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupingInd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupingInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("vendCheckName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? VendCheckName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_EDIT_DEFER_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("editDeferInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? EditDeferInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_HOLD_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("holdInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HoldInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_OPEN_PAID_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openPaidInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? OpenPaidInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_ATYP_SEQ_NUM
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypSeqNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AtypSeqNum { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("matchTempReq", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? MatchTempReq { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_SUSP_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suspInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SuspInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("itypDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ItypDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? City { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_CARRIER_ROUTE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("carrierRoute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CarrierRoute { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("taxDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? TaxDesc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("page2State", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Page2State { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_1099_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("1099Ind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? _1099Ind { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_TRANS_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset TransDate { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("iatInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? IatInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("currDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CurrDesc { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvstat
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faainvhStatCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaainvhStatCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_CR_MEMO_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crMemoInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? CrMemoInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_PMT_DUE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pmtDueDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PmtDueDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_BANK_CODE, Lookup lineage reference object : gxvbank
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bankCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BankCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("page2ZipCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Page2ZipCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_ATYP_CODE_VEND, Lookup lineage reference object : ftvatyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypCodeVend", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AtypCodeVend { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_INVOICE_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoiceDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset InvoiceDate { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_ACHT_CODE, Lookup lineage reference object : gtvacht
        /// </summary>
        [Newtonsoft.Json.JsonProperty("achtCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AchtCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("faainvhVendCheckCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? FaainvhVendCheckCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addrLine3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddrLine3 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addrLine2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddrLine2 { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("addrLine1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AddrLine1 { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : stvnatn
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spraddrNatnCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? SpraddrNatnCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_ACH_OVERRIDE_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("achOverrideInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AchOverrideInd { get; set; } = default!;

        /// <summary>
        /// Lookup lineage reference object : ftvityp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("itypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ItypCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : FABINVH_ATYP_CODE, Lookup lineage reference object : stvatyp
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atypCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AtypCode { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("headerBankName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? HeaderBankName { get; set; } = default!;

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