// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The country with specific educational institution codes
    /// </summary>
    [DataContract]
    public class StandardizedCeebCodesDtoProperty
    {
        /// <summary>
        /// Codes for the United States of America ISO 3166-1 alpha-3 country code
        /// </summary>
        [DataMember(Name = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// The CEEB code that is assigned to the institution
        /// </summary>
        [DataMember(Name = "ceeb", EmitDefaultValue = false)]
        public string Ceeb { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public StandardizedCeebCodesDtoProperty()
        {
            Code = "USA";
        }
    }


    /// <summary>
    /// Standardized education specific codes/IDs that are assigned to the institution
    /// </summary>
    [DataContract]
    public class StandardizedCodesDtoProperty
    {
        /// <summary>
        /// The country with specific educational institution codes.
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public StandardizedCeebCodesDtoProperty Country { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public StandardizedCodesDtoProperty()
        {
            Country = new StandardizedCeebCodesDtoProperty();
        }

    }
}