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

namespace Ellucian.Generated.BpApi.Ban.StudentAccountSummariesV100PutResponse
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class StudentAccountSummariesV100PutResponse
    {
        [Newtonsoft.Json.JsonProperty("acct_bal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Acct_bal>? Acct_bal { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbbacct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbbacct>? Tbbacct { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbrcolc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbrcolc>? Tbrcolc { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbristl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbristl>? Tbristl { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("tbbcstu", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Tbbcstu>? Tbbcstu { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Acct_bal
    {
        /// <summary>
        /// Lineage reference object : effDate91
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate91", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? EffDate91 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : balanceDue
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balanceDue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? BalanceDue { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : billDateUnbilled
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billDateUnbilled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? BillDateUnbilled { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : effDate61
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate61", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? EffDate61 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : effDateFut
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDateFut", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? EffDateFut { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : memoBal
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memoBal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? MemoBal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : billDate91
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billDate91", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? BillDate91 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : pastDue
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pastDue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? PastDue { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : netBal
        /// </summary>
        [Newtonsoft.Json.JsonProperty("netBal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? NetBal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : depoBal
        /// </summary>
        [Newtonsoft.Json.JsonProperty("depoBal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? DepoBal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : currentDue
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currentDue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? CurrentDue { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : futureDue
        /// </summary>
        [Newtonsoft.Json.JsonProperty("futureDue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? FutureDue { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : acctBal
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acctBal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? AcctBal { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : nsfCounter
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nsfCounter", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? NsfCounter { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : amountDue
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amountDue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? AmountDue { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : effDate0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate0", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? EffDate0 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : unappliedCr
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unappliedCr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? UnappliedCr { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : billDate61
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billDate61", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? BillDate61 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : billDate31
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billDate31", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? BillDate31 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : effDate31
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effDate31", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? EffDate31 { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : billDate0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billDate0", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? BillDate0 { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tbbacct
    {
        [Newtonsoft.Json.JsonProperty("deliDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeliDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBACCT_DELI_CODE, Lookup lineage reference object : ttvdeli
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DeliCode { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBACCT_REFUND_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? RefundInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("billCodeDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BillCodeDesc { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBACCT_BILL_CODE, Lookup lineage reference object : ttvbill
        /// </summary>
        [Newtonsoft.Json.JsonProperty("billCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? BillCode { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tbrcolc
    {
        [Newtonsoft.Json.JsonProperty("colcId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ColcId { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("colcName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ColcName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRCOLC_COLC_AGENCY_DATE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("colcAgencyDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ColcAgencyDate { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tbristl
    {
        /// <summary>
        /// Lineage reference object : TBRISTL_REF_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RefNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_INSTALLMENT_PLAN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("installmentPlan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? InstallmentPlan { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_PLAN_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("planAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PlanAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBRISTL_DESC
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Desc { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.16.1.0 (NJsonSchema v10.7.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tbbcstu
    {
        /// <summary>
        /// Lineage reference object : TBBCSTU_CONTRACT_PRIORITY
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractPriority", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ContractPriority { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_AUTH_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AuthInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("contId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContId { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_DEL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? DelInd { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_STSP_KEY_SEQUENCE
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stspKeySequence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? StspKeySequence { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("contDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContDescription { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_MAX_STUDENT_AMOUNT
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxStudentAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxStudentAmount { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_STUDENT_CONT_ROLL_IND
        /// </summary>
        [Newtonsoft.Json.JsonProperty("studentContRollInd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? StudentContRollInd { get; set; } = default!;

        [Newtonsoft.Json.JsonProperty("contName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? ContName { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_AUTH_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? AuthNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_CONTRACT_NUMBER
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ContractNumber { get; set; } = default!;

        /// <summary>
        /// Lineage reference object : TBBCSTU_TERM_CODE, Lookup lineage reference object : stvterm
        /// </summary>
        [Newtonsoft.Json.JsonProperty("termCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TermCode { get; set; } = default!;

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