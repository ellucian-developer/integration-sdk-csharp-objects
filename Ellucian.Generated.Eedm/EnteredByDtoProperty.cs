// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The creator of this comment instance
    /// </summary>
    [DataContract]
    public class EnteredByDtoProperty
    {
        /// <summary>
        /// Globally unique Identifier (GUID)
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the person who entered the comment
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public EnteredByDtoProperty()
        {
        }
    }
}