// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The response to a professional judgement request for a financial aid applicantion.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidApplicationOutcomesProfessionalJudgement
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
        
        /// <summary>
        /// processed
        /// </summary>
        [EnumMember(Value = "processed")]
        Processed,

        /// <summary>
        /// request failed
        /// </summary>
        [EnumMember(Value = "requestFailed")]
        RequestFailed,

    }
}
