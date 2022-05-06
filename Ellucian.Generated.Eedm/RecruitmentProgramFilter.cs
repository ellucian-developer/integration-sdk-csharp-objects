// Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Active on named query
    /// </summary>
    public class RecruitmentProgramFilter
    {
        /// <summary>
        /// activeOn
        /// </summary>        
        [DataMember(Name = "recruitmentProgram", EmitDefaultValue = false)]
        [FilterProperty("recruitmentProgram")]
        public RecruitmentProgramType? RecruitmentProgram { get; set; }
    }
}
