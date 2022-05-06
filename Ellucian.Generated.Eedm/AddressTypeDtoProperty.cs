// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an address
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddressTypeDtoProperty
    {
        /// <summary>
        /// Home
        /// </summary>
        Home,

        /// <summary>
        /// Mailing
        /// </summary>
        Mailing,

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