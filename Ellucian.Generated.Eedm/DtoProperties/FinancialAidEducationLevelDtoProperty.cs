// Copyright 2015-2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The highest education level completed by the applicant's parents.
    /// </summary>
    [DataContract]
    public class FinancialAidEducationLevelDtoProperty
    {
        /// <summary>
        /// The marital status title.
        /// </summary>
        [DataMember(Name = "firstParent", EmitDefaultValue = false )]
        public FinancialAidApplicationsEducationLevel FirstParent { get; set; }

        /// <summary>
        /// The marital status value.
        /// </summary>
        [DataMember( Name = "secondParent", EmitDefaultValue = false )]
        public FinancialAidApplicationsEducationLevel SecondParent { get; set; }
    }
}