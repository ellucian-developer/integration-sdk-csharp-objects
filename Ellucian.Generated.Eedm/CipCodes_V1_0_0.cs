// Copyright 2020 Ellucian Company L.P. and its affiliates.
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A designation of a student's progress, based on the number of completed courses
    /// </summary>
    [DataContract]
    public class CipCodes_V1_0_0 : CodeItem2
    {
        /// <summary>
        /// The revision year associated with the CIP code.
        /// </summary>
        [DataMember(Name = "revisionYear", EmitDefaultValue = false)]
        public int? RevisionYear { get; set; }
    }
}