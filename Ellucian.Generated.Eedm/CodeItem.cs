// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A code item
    /// </summary>
    [DataContract]
    public abstract class CodeItem : BaseModel
    {
        /// <summary>
        /// A shortened or contracted form of a word or phrase, used to represent the whole, as Dr. for Doctor. Abbreviations are not assumed to be unique.
        /// </summary>
        [DataMember(Name = "abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// The human-readable name of a resource.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The human-readable description of a resource.
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Code item constructor
        /// </summary>
        protected CodeItem() : base() { }
    }
}