// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The name of the contact.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonContactName
    {
        /// <summary>
        /// The value of the FullName
        /// </summary>
        [JsonProperty("fullName", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string FullName { get; set; }

        /// <summary>
        /// The value of the FirstName
        /// </summary>
        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// The value of the MiddleName
        /// </summary>
        [JsonProperty("middleName", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string MiddleName { get; set; }

        /// <summary>
        /// The value of the LastName
        /// </summary>
        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }
    }
}