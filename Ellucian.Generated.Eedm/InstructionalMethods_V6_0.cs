// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A method, style, or format in which a Course is taught.
    /// </summary>
    [DataContract]
    public class InstructionalMethods_V6_0 : BaseModel2
    {
        /// <summary>
        /// A shortened or contracted form of a word or phrase, used to represent the whole. Abbreviations are not assumed to be unique.
        /// </summary>
        [DataMember(Name = "abbreviation")]
        public string Code { get; set; }

        /// <summary>
        /// The human-readable name of a resource.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The human-readable description of a resource.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Instructional Method constructor
        /// </summary>
        //protected InstructionalMethod2() : base() { }
    }
}