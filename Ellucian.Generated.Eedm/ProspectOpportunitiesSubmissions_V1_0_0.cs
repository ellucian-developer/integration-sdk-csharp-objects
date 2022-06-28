//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The opportunities for a prospective student at an institution. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ProspectOpportunitiesSubmissions_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The person who is interested in attending the institution.
        /// </summary>

        [JsonProperty("prospect", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Prospect { get; set; }

        /// <summary>
        /// The person who is interested in attending the institution and the academic program they are considering at the institution.
        /// </summary>

        [JsonProperty("recruitAcademicPrograms", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<RecruitAcademicProgram> RecruitAcademicPrograms { get; set; }

        /// <summary>
        /// The academic period the prospect is interested in beginning attendance at the institution.
        /// </summary>

        [JsonProperty("entryAcademicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 EntryAcademicPeriod { get; set; }

        /// <summary>
        /// The admission population the prospect would be included within at the institution if they attend the institution.
        /// </summary>

        [JsonProperty("admissionPopulation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AdmissionPopulation { get; set; }

        /// <summary>
        /// The institution site (campus) the prospect is considering.
        /// </summary>

        [JsonProperty("site", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Site { get; set; }

        /// <summary>
        /// The source associated with the prospect opportunity.
        /// </summary>

        [JsonProperty("opportunitySource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 OpportunitySource { get; set; }

        /// <summary>
        /// The source associated with the applicant.
        /// </summary>

        [JsonProperty("personSource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 PersonSource { get; set; }

        /// <summary>
        /// The education goal associated with the application
        /// </summary>
        [JsonProperty("educationalGoal", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 EducationalGoal { get; set; }

        /// <summary>
        /// The career goals associated with the application
        /// </summary>
        [JsonProperty("careerGoals", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> CareerGoals
        {
            get; set;
        }
    }
}