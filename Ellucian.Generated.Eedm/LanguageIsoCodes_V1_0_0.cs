﻿//Copyright 2019 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The valid list of languages. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class LanguageIsoCodes_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The full name of the language.
        /// </summary>

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The code used to identify the language.
        /// </summary>

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// The ISO code used to identify the language.
        /// </summary>

        [JsonProperty("isoCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string IsoCode { get; set; }

        /// <summary>
        /// An indicator as to whether the ISO code is currently in use or was previously used to represent a language.
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Status Status { get; set; }
    }
}
