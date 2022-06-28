// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A country
    /// </summary>
    [DataContract]
    public class Country
    {
        /// <summary>
        /// The country code
        /// </summary>
        [DataMember(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        /// The name of the country
        /// </summary>
        [DataMember(Name = "value")]
        public string Value { get; set; }
    }
}