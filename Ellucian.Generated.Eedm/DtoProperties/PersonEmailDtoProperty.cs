// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a email address.
    /// </summary>
    [DataContract]
    public class PersonEmailDtoProperty
    {
        /// <summary>
        /// The <see cref="PersonEmailTypeDtoProperty">type</see> of email
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonEmailTypeDtoProperty Type { get; set; }

        /// <summary>
        /// Specifies if the email is preferred over others of the same type.
        /// </summary>
        [JsonProperty("preference", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonEmailPreference? Preference { get; set; }

        /// <summary>
        /// An email address for the person.
        /// </summary>
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string Address { get; set; }
    }
}