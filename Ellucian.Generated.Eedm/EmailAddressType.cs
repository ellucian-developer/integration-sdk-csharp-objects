// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an email address
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EmailAddressType
    {
        /// <summary>
        /// Institution
        /// </summary>
        Institution,

        /// <summary>
        /// Personal
        /// </summary>
        Personal,

        /// <summary>
        /// Work
        /// </summary>
        Work
    }
}