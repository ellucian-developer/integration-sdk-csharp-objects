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
    /// Whom the comment is about
    /// </summary>
    [DataContract]
    public class SubjectMatterDtoProperty
    {
        /// <summary>
        /// The person whom the comment is about
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The comment is made about this organization.
        /// </summary>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public GuidObject2 Organization { get; set; }

        /// <summary>
        /// The comment is made about this institution.
        /// </summary>
        [DataMember(Name = "institution", EmitDefaultValue = false)]
        public GuidObject2 Institution { get; set; }

        /// <summary>
        /// The comment is made about this institution Unit (Not Supported).
        /// </summary>
        [DataMember(Name = "institutionUnit", EmitDefaultValue = false)]
        public GuidObject2 InstitutionUnit { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public SubjectMatterDtoProperty()
        {
        }
    }
}