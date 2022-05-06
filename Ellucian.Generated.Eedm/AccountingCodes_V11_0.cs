// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of contacts where comments can be made
    /// </summary>
    [DataContract]
    public class AccountingCodes_V11_0 : CodeItem2
    {
        /// <summary>
        /// The top level category of the accounting code.
        /// </summary>
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public AccountingCodeCategoryDtoProperty AccountingCodeCategory { get; set; }
    }
}