// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The applicant's marital status.
    /// </summary>
    [DataContract]
    public class MaritalStatusDtoProperty
    {
        /// <summary>
        /// The marital status title.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false )]
        public string Title { get; set; }

        /// <summary>
        /// The marital status value.
        /// </summary>
        [DataMember( Name = "value", EmitDefaultValue = false )]
        public string Value { get; set; }
    }
}