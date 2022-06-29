﻿// Copyright 2015-2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Base class that contains Detail, Code, Title properties
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class BaseCodeTitleDetailDtoProperty
    {
        /// <summary>
        /// Id of the InstructionalPlatform
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// Code of the InstructionalPlatform
        /// </summary>
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Title of the InstructionalPlatform
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public BaseCodeTitleDetailDtoProperty()
        {
            Detail = new GuidObject2();
        }
    }
}
