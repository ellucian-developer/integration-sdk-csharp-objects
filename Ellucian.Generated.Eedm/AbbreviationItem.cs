// Copyright 2015-2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An abbreviation that identifies an academic discipline.
    /// </summary>
    [DataContract]
    public class AbbreviationItem: BaseModel2
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
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Code item constructor
        /// </summary>
        protected AbbreviationItem() : base() { }
    }
}
