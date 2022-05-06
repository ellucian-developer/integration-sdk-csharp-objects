// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible Contact Preferences
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContactPreference
    {
        /// <summary>
        /// Preferred
        /// </summary>
        Preferred
    }
}