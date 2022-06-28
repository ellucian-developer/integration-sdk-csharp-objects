// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible phone types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PhoneType
    {
        /// <summary>
        /// Home
        /// </summary>
        Home,

        /// <summary>
        /// Mobile
        /// </summary>
        Mobile,

        /// <summary>
        /// Residence
        /// </summary>
        Residence,

        /// <summary>
        /// Work
        /// </summary>
        Work
    }
}