// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of the general ledger transaction (e.g. journal entry, encumbrance, budget).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GeneralLedgerTransactionType
    {
        /// <summary>
        /// Approved Budget
        /// </summary>
        [EnumMember(Value = "approvedBudget")]
        ApprovedBudget,

        /// <summary>
        /// Contigent Budget
        /// </summary>
        [EnumMember(Value = "contingentBudget")]
        ContingentBudget,

        /// <summary>
        /// Approved Budget Adjustment
        /// </summary>
        [EnumMember(Value = "approvedBudgetAdjustment")]
        ApprovedBudgetAdjustment,

        /// <summary>
        /// Temporary Budget
        /// </summary>
        [EnumMember(Value = "temporaryBudget")]
        TemporaryBudget,

        /// <summary>
        /// Temporary Budget Adjustment
        /// </summary>
        [EnumMember(Value = "temporaryBudgetAdjustment")]
        TemporaryBudgetAdjustment,

        /// <summary>
        /// Encumbrance OpenBalance
        /// </summary>
        [EnumMember(Value = "encumbranceOpenBalance")]
        EncumbranceOpenBalance,

        /// <summary>
        /// General Encumbrance Create
        /// </summary>
        [EnumMember(Value = "generalEncumbranceCreate")]
        GeneralEncumbranceCreate,

        /// <summary>
        /// General Encumbrance Adjust
        /// </summary>
        [EnumMember(Value = "generalEncumbranceAdjust")]
        GeneralEncumbranceAdjust,

        /// <summary>
        /// General Encumbrance Liquidation
        /// </summary>
        [EnumMember(Value = "generalEncumbranceLiquidation")]
        GeneralEncumbranceLiquidation,

        /// <summary>
        /// General Encumbrance Close
        /// </summary>
        [EnumMember(Value = "generalEncumbranceClose")]
        GeneralEncumbranceClose,

        /// <summary>
        /// Payroll Encumbrance Create
        /// </summary>
        [EnumMember(Value = "payrollEncumbranceCreate")]
        PayrollEncumbranceCreate,

        /// <summary>
        /// Payroll Encumbrance Adjust
        /// </summary>
        [EnumMember(Value = "payrollEncumbranceAdjust")]
        PayrollEncumbranceAdjust,

        /// <summary>
        /// Payroll Encumbrance Liquidation
        /// </summary>
        [EnumMember(Value = "payrollEncumbranceLiquidation")]
        PayrollEncumbranceLiquidation,

        /// <summary>
        /// Payroll Encumbrance Close
        /// </summary>
        [EnumMember(Value = "payrollEncumbranceClose")]
        PayrollEncumbranceClose,

        /// <summary>
        /// Travel Encumbrance Create
        /// </summary>
        [EnumMember(Value = "travelEncumbranceCreate")]
        travelEncumbranceCreate,

        /// <summary>
        /// Travel Encumbrance Adjust
        /// </summary>
        [EnumMember(Value = "travelEncumbranceAdjust")]
        TravelEncumbranceAdjust,

        /// <summary>
        /// Travel Encumbrance Close
        /// </summary>
        [EnumMember(Value = "travelEncumbranceClose")]
        TravelEncumbranceClose,

        /// <summary>
        /// Donation
        /// </summary>
        [EnumMember(Value = "donation")]
        Donation,

        /// <summary>
        /// Donation Endowed
        /// </summary>
        [EnumMember(Value = "donationEndowed")]
        DonationEndowed,

        /// <summary>
        /// Pledge
        /// </summary>
        [EnumMember(Value = "pledge")]
        Pledge,

        /// <summary>
        /// Pledge Endowed
        /// </summary>
        [EnumMember(Value = "pledgeEndowed")]
        PledgeEndowed,

        /// <summary>
        /// Financial Aid Transmittal
        /// </summary>
        [EnumMember(Value = "financialAidTransmittal")]
        FinancialAidTransmittal,

        /// <summary>
        /// Student Charge
        /// </summary>
        [EnumMember(Value = "studentCharge")]
        StudentCharge,

        /// <summary>
        /// Student Invoice
        /// </summary>
        [EnumMember(Value = "studentInvoice")]
        StudentInvoice,

        /// <summary>
        /// Student Payment
        /// </summary>
        [EnumMember(Value = "studentPayment")]
        StudentPayment,

        /// <summary>
        /// Grant Charge
        /// </summary>
        [EnumMember(Value = "grantCharge")]
        GrantCharge,

        /// <summary>
        /// Grant Invoice
        /// </summary>
        [EnumMember(Value = "grantInvoice")]
        GrantInvoice,

        /// <summary>
        /// Grant Payment
        /// </summary>
        [EnumMember(Value = "grantPayment")]
        GrantPayment,

        /// <summary>
        /// Other Charge
        /// </summary>
        [EnumMember(Value = "otherCharge")]
        OtherCharge,

        /// <summary>
        /// Other Invoice
        /// </summary>
        [EnumMember(Value = "otherInvoice")]
        OtherInvoice,

        /// <summary>
        /// Other Payment
        /// </summary>
        [EnumMember(Value = "otherPayment")]
        OtherPayment,

        /// <summary>
        /// Payment Allocation
        /// </summary>
        [EnumMember(Value = "paymentAllocation")]
        PaymentAllocation,

        /// <summary>
        /// Deposit Allocation
        /// </summary>
        [EnumMember(Value = "depositAllocation")]
        DepositAllocation,

        /// <summary>
        /// Misc Cash Receipt
        /// </summary>
        [EnumMember(Value = "miscCashReceipt")]
        MiscCashReceipt,

        /// <summary>
        /// Cash Disbursement
        /// </summary>
        [EnumMember(Value = "cashDisbursement")]
        CashDisbursement,

        /// <summary>
        /// Purchase Card Charge
        /// </summary>
        [EnumMember(Value = "purchaseCardCharge")]
        PurchaseCardCharge,

        /// <summary>
        /// Misc General Ledger Transaction
        /// </summary>
        [EnumMember(Value = "miscGeneralLedgerTransaction")]
        MiscGeneralLedgerTransaction,

        /// <summary>
        /// Purchase Journal
        /// </summary>
        [EnumMember(Value = "purchaseJournal")]
        PurchaseJournal,

        /// <summary>
        /// Travel Advance
        /// </summary>
        [EnumMember(Value = "travelAdvance")]
        TravelAdvance,

        /// <summary>
        /// Travel Expense
        /// </summary>
        [EnumMember(Value = "travelExpense")]
        TravelExpense,

        /// <summary>
        /// Year End Close Entry
        /// </summary>
        [EnumMember(Value = "yearEndCloseEntry")]
        YearEndCloseEntry,

        /// <summary>
        /// Payroll
        /// </summary>
        [EnumMember(Value = "payroll")]
        Payroll,

        /// <summary>
        /// Payroll With Liquidation
        /// </summary>
        [EnumMember(Value = "payrollWithLiquidation")]
        PayrollWithLiquidation,

        /// <summary>
        /// Actual Open Balance
        /// </summary>
        [EnumMember(Value = "actualOpenBalance")]
        ActualOpenBalance
    }
}
