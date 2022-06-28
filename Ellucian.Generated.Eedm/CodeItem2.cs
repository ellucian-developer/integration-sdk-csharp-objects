// Copyright 2015-2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A code item Version 4 of HeDM
    /// </summary>
    [DataContract]
    public abstract class CodeItem2 : BaseModel2
    {
        /// <summary>
        /// A shortened or contracted form of a word or phrase, used to represent the whole. Abbreviations are not assumed to be unique.
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The human-readable name of a resource.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The human-readable description of a resource.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Code item constructor
        /// </summary>
        protected CodeItem2() : base() { }
    }
}