// Copyright 2016-2018 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The institutional unit that authorizes the academic program.
    /// </summary>
    [DataContract]
    public class AcademicProgramAuthorizing
    {
        /// <summary>
        /// The institution that authorizes the academic program.
        /// </summary>
        [DataMember(Name = "institution", EmitDefaultValue = false)]
        public GuidObject2 AuthorizingInstitution { get; set; }

        /// <summary>
        /// The organization that authorizes the academic program.
        /// </summary>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public GuidObject2 Organization { get; set; }

        /// <summary>
        /// The institutional unit that authorizes the academic program.
        /// </summary>
        [DataMember(Name = "institutionalUnit", EmitDefaultValue = false)]
        public GuidObject2 AuthorizingInstitutionUnit { get; set; }
    }
}