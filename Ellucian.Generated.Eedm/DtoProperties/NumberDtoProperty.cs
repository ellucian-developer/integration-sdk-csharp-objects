// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The number (phone or fax)
    /// </summary>
    [DataContract]
    public class NumberDtoProperty
    {
        /// <summary>
        /// The telephone number.
        /// </summary>
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Number { get; set; }

    }
}