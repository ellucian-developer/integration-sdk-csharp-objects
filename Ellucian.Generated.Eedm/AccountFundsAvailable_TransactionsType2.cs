// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of the general ledger transaction (e.g. journal entry, encumbrance, budget).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountFundsAvailable_TransactionsType2
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// approvedBudget
        /// </summary>
        [EnumMember(Value = "approvedBudget")]
        approvedBudget,

        /// <summary>
        /// contingentBudget
        /// </summary>
        [EnumMember(Value = "contingentBudget")]
        contingentBudget,

        /// <summary>
        /// approvedBudgetAdjustment
        /// </summary>
        [EnumMember(Value = "approvedBudgetAdjustment")]
        approvedBudgetAdjustment,

        /// <summary>
        /// temporaryBudget
        /// </summary>
        [EnumMember(Value = "temporaryBudget")]
        temporaryBudget,

        /// <summary>
        /// temporaryBudgetAdjustment
        /// </summary>
        [EnumMember(Value = "temporaryBudgetAdjustment")]
        temporaryBudgetAdjustment,

        /// <summary>
        /// encumbranceOpenBalance
        /// </summary>
        [EnumMember(Value = "encumbranceOpenBalance")]
        encumbranceOpenBalance,

        /// <summary>
        /// generalEncumbranceCreate
        /// </summary>
        [EnumMember(Value = "generalEncumbranceCreate")]
        generalEncumbranceCreate,

        /// <summary>
        /// generalEncumbranceAdjust
        /// </summary>
        [EnumMember(Value = "generalEncumbranceAdjust")]
        generalEncumbranceAdjust,

        /// <summary>
        /// generalEncumbranceLiquidation
        /// </summary>
        [EnumMember(Value = "generalEncumbranceLiquidation")]
        generalEncumbranceLiquidation,

        /// <summary>
        /// generalEncumbranceClose
        /// </summary>
        [EnumMember(Value = "generalEncumbranceClose")]
        generalEncumbranceClose,

        /// <summary>
        /// payrollEncumbranceCreate
        /// </summary>
        [EnumMember(Value = "payrollEncumbranceCreate")]
        payrollEncumbranceCreate,

        /// <summary>
        /// payrollEncumbranceAdjust
        /// </summary>
        [EnumMember(Value = "payrollEncumbranceAdjust")]
        payrollEncumbranceAdjust,

        /// <summary>
        /// payrollEncumbranceLiquidation
        /// </summary>
        [EnumMember(Value = "payrollEncumbranceLiquidation")]
        payrollEncumbranceLiquidation,

        /// <summary>
        /// payrollEncumbranceClose
        /// </summary>
        [EnumMember(Value = "payrollEncumbranceClose")]
        payrollEncumbranceClose,

        /// <summary>
        /// travelEncumbranceCreate
        /// </summary>
        [EnumMember(Value = "travelEncumbranceCreate")]
        travelEncumbranceCreate,

        /// <summary>
        /// travelEncumbranceAdjust
        /// </summary>
        [EnumMember(Value = "travelEncumbranceAdjust")]
        travelEncumbranceAdjust,

        /// <summary>
        /// travelEncumbranceClose
        /// </summary>
        [EnumMember(Value = "travelEncumbranceClose")]
        travelEncumbranceClose,

        /// <summary>
        /// donation
        /// </summary>
        [EnumMember(Value = "donation")]
        donation,

        /// <summary>
        /// donationEndowed
        /// </summary>
        [EnumMember(Value = "donationEndowed")]
        donationEndowed,

        /// <summary>
        /// pledge
        /// </summary>
        [EnumMember(Value = "pledge")]
        pledge,

        /// <summary>
        /// pledgeEndowed
        /// </summary>
        [EnumMember(Value = "pledgeEndowed")]
        pledgeEndowed,

        /// <summary>
        /// financialAidTransmittal
        /// </summary>
        [EnumMember(Value = "financialAidTransmittal")]
        financialAidTransmittal,

        /// <summary>
        /// studentCharge
        /// </summary>
        [EnumMember(Value = "studentCharge")]
        studentCharge,

        /// <summary>
        /// studentInvoice
        /// </summary>
        [EnumMember(Value = "studentInvoice")]
        studentInvoice,

        /// <summary>
        /// studentPayment
        /// </summary>
        [EnumMember(Value = "studentPayment")]
        studentPayment,

        /// <summary>
        /// grantCharge
        /// </summary>
        [EnumMember(Value = "grantCharge")]
        grantCharge,

        /// <summary>
        /// grantInvoice
        /// </summary>
        [EnumMember(Value = "grantInvoice")]
        grantInvoice,

        /// <summary>
        /// grantPayment
        /// </summary>
        [EnumMember(Value = "grantPayment")]
        grantPayment,

        /// <summary>
        /// otherCharge
        /// </summary>
        [EnumMember(Value = "otherCharge")]
        otherCharge,

        /// <summary>
        /// otherInvoice
        /// </summary>
        [EnumMember(Value = "otherInvoice")]
        otherInvoice,

        /// <summary>
        /// otherPayment
        /// </summary>
        [EnumMember(Value = "otherPayment")]
        otherPayment,

        /// <summary>
        /// paymentAllocation
        /// </summary>
        [EnumMember(Value = "paymentAllocation")]
        paymentAllocation,

        /// <summary>
        /// depositAllocation
        /// </summary>
        [EnumMember(Value = "depositAllocation")]
        depositAllocation,

        /// <summary>
        /// miscCashReceipt
        /// </summary>
        [EnumMember(Value = "miscCashReceipt")]
        miscCashReceipt,

        /// <summary>
        /// cashDisbursement
        /// </summary>
        [EnumMember(Value = "cashDisbursement")]
        cashDisbursement,

        /// <summary>
        /// purchaseCardCharge
        /// </summary>
        [EnumMember(Value = "purchaseCardCharge")]
        purchaseCardCharge,

        /// <summary>
        /// miscGeneralLedgerTransaction
        /// </summary>
        [EnumMember(Value = "miscGeneralLedgerTransaction")]
        miscGeneralLedgerTransaction,

        /// <summary>
        /// purchaseJournal
        /// </summary>
        [EnumMember(Value = "purchaseJournal")]
        purchaseJournal,

        /// <summary>
        /// travelAdvance
        /// </summary>
        [EnumMember(Value = "travelAdvance")]
        travelAdvance,

        /// <summary>
        /// travelExpense
        /// </summary>
        [EnumMember(Value = "travelExpense")]
        travelExpense,

        /// <summary>
        /// yearEndCloseEntry
        /// </summary>
        [EnumMember(Value = "yearEndCloseEntry")]
        yearEndCloseEntry,

        /// <summary>
        /// payroll
        /// </summary>
        [EnumMember(Value = "payroll")]
        payroll,

        /// <summary>
        /// payrollWithLiquidation
        /// </summary>
        [EnumMember(Value = "payrollWithLiquidation")]
        payrollWithLiquidation,

        /// <summary>
        /// actualOpenBalance
        /// </summary>
        [EnumMember(Value = "actualOpenBalance")]
        actualOpenBalance,

        /// <summary>
        /// requisition
        /// </summary>
        [EnumMember(Value = "requisition")]
        requisition,

        /// <summary>
        /// purchaseOrder
        /// </summary>
        [EnumMember(Value = "purchaseOrder")]
        purchaseOrder
    }
}


