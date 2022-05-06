// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The detailed accounting lines associated with the transaction.
    /// </summary>
    [DataContract]
    public class GeneralLedgerReferenceDtoProperty
    {
        /// <summary>
        /// A string that identifies a person associated with the transaction.
        /// </summary>
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// Reference Organization
        /// </summary>
        [JsonProperty("organization", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Organization { get; set; }
    }
}