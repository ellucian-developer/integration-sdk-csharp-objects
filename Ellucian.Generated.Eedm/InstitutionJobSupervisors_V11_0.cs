//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A detailed description of the job at an institution. 
    /// </summary>
    [DataContract]
    public class InstitutionJobSupervisors_V11_0
    {
        /// <summary>
        /// A Globally Unique ID (GUID)
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The employee to which the job is associated.
        /// </summary>
        [DataMember(Name = "person")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The operational unit of the institution to which the job belongs.
        /// </summary>
        [DataMember(Name = "employer")]
        public GuidObject2 Employer { get; set; }

        /// <summary>
        /// The position associated with the job.
        /// </summary>
        [DataMember(Name = "position")]
        public GuidObject2 Position { get; set; }

        /// <summary>
        /// The department of the institution to which the job belongs.
        /// </summary>
        [DataMember(Name = "department")]
        public string Department { get; set; }

        /// <summary>
        /// The supervisor associated with the job.
        /// </summary>
        [DataMember(Name = "supervisors", EmitDefaultValue = false)]
        public List<SupervisorsDtoProperty> Supervisors { get; set; }

    }
}
