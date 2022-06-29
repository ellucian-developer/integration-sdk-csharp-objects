// Copyright 2018 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The initiator
    /// </summary>
    [DataContract]
    public class IncompleteGradeDetailsDtoProperty
    {
        /// <summary>
        /// The default final grade to be assigned to this section registration when extension date is passed.
        /// </summary>
        [DataMember(Name = "finalGradeDefault", EmitDefaultValue = false)]
        public GuidObject2 FinalGradeDefault { get; set; }
    }
}