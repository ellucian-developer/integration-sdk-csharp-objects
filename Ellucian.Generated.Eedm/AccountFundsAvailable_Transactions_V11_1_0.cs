//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A check on the availability of funds for all accounts involved in transactions. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountFundsAvailable_Transactions_V11_1_0
    {
        /// <summary>
        /// A list of associated general ledger transactions.
        /// </summary>

        [JsonProperty("transactions")]
        public List<AccountFundsAvailable_Transactionstransactions2> Transactions { get; set; }

    }


    /// <summary>
    /// A list of associated general ledger transactions. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountFundsAvailable_Transactionstransactions2
    {


        /// <summary>
        /// The type of the general ledger transaction (e.g. journal entry, encumbrance, budget).
        /// </summary>      
        [JsonProperty("type")]
        public AccountFundsAvailable_TransactionsType2 Type { get; set; }

        /// <summary>
        /// The date on which the transaction is to occur.
        /// </summary>      
        [JsonProperty("transactionDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? TransactionDate { get; set; }

        /// <summary>
        /// The detailed accounting lines associated with the transaction.
        /// </summary>        
        [JsonProperty("transactionDetailLines")]
        public List<AccountFundsAvailable_TransactionstransactionDetailLines2> TransactionDetailLines { get; set; }

      
    }

    /// <summary>
    /// The detailed accounting lines associated with the transaction. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountFundsAvailable_TransactionstransactionDetailLines2
    {
        /// <summary>
        /// The accounting string associated with the transaction detail line.
        /// </summary>

        [JsonProperty("accountingString")]
        public string AccountingString { get; set; }

        /// <summary>
        /// Status of the availability of funds.
        /// </summary>

        [JsonProperty("fundsAvailable")]
        public FundsAvailable FundsAvailable { get; set; }

        /// <summary>
        /// The type of detailed accounting line (credit/debit).
        /// </summary>

        [JsonProperty("type")]
        public CreditOrDebit? Type { get; set; }

        /// <summary>
        /// The amount of the credit or debit.
        /// </summary>

        [JsonProperty("amount")]
        public AmountDtoProperty Amount { get; set; }

        /// <summary>
        /// The person who made the submit request.
        /// </summary>

        [JsonProperty("submittedBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 SubmittedBy { get; set; }

        /// <summary>
        /// The reference document checked for available funds.
        /// </summary>
        [JsonProperty("referenceDocument", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ReferenceDocumentDtoProperty ReferenceDocument { get; set; }


    }
}