// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The employement status type and detail
    /// </summary>
    [DataContract]
    public class ContractTypeDtoProperty
    {

        /// <summary>
        /// The type of employment (Eg. Full-time or Part-time).
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ContractType? Type { get; set; }

        /// <summary>
        /// The Guid of the type of employment (Eg. Full-time or Part-time).
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }
    }
}