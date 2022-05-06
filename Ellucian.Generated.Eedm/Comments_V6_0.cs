// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    ///  Comments made about a person, organization, etc.
    /// </summary>
    [DataContract]
    public class Comments_V6_0 : BaseModel2
    {
        /// <summary>
        /// Confidential level of the comment
        /// </summary>
        [DataMember(Name = "confidentiality")]
        public ConfidentialCategory? Confidentiality { get; set; }
  
        /// <summary>
        /// Whom the comment is about
        /// </summary>
        [DataMember(Name = "subjectMatter")]
        public SubjectMatterDtoProperty SubjectMatter { get; set; }

        /// <summary>
        /// Source of the comment
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public GuidObject2 Source { get; set; }

        /// <summary>
        /// Subject area of the comment
        /// </summary>
        [DataMember(Name = "commentSubjectArea", EmitDefaultValue = false)]
        public GuidObject2 CommentSubjectArea { get; set; }

        /// <summary>
        /// The actual comment made
        /// </summary>
        [DataMember(Name = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// The creator of this comment instance
        /// </summary>
        [DataMember(Name = "enteredBy", EmitDefaultValue = false)]
        public EnteredByDtoProperty EnteredBy { get; set; }

        /// <summary>
        /// The date of the creation of the comment instance
        /// </summary>
        [DataMember(Name = "enteredOn", EmitDefaultValue = false)]
        public DateTime? EnteredOn { get; set; }

    }
}