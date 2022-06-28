// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enrollment of a Student in an academic program
    /// </summary>
    [DataContract]
    public class StudentAcademicPrograms_V7_0 :BaseModel2
    {
        /// <summary>
        /// The student who is enrolled in an academic program.
        /// </summary>
        [DataMember(Name = "student")]
        [FilterProperty("criteria")]
        public GuidObject2 Student { get; set; }

        /// <summary>
        /// The academic program in which a student is enrolled.
        /// </summary>
        [DataMember(Name = "program")]
        [FilterProperty("criteria")]
        public GuidObject2 Program { get; set; }

        /// <summary>
        /// The owner of the academic program.
        /// </summary>
        [DataMember(Name = "programOwner", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public GuidObject2 ProgramOwner { get; set; }

        /// <summary>
        /// The site (campus) the student enrolls for the program at.
        /// </summary>
        [DataMember(Name = "site", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public GuidObject2 Site { get; set; }

        /// <summary>
        /// The academic catalog that defines the requirements for a student's enrollment in a program.
        /// </summary>
        [DataMember(Name = "catalog")]
        [FilterProperty("criteria")]
        public GuidObject2 Catalog { get; set; }

        /// <summary>
        /// The academic level associated with the enrollment of the student in the academic program.
        /// </summary>
        [DataMember(Name = "academicLevel", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// The academic credentials that can be awarded for completing an academic program.
        /// </summary>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public List<GuidObject2> Credentials { get; set; }

        /// <summary>
        /// The academic disciplines offered as part of an academic program.
        /// </summary>
        [DataMember(Name = "disciplines", EmitDefaultValue = false)]
        public List<StudentAcademicProgramDisciplines> Disciplines { get; set; }

        /// <summary>
        /// The date on which an academic program begins.
        /// </summary>
        [DataMember(Name = "startOn")]
        [FilterProperty("criteria")]
        public DateTimeOffset? StartDate { get; set; }

         /// <summary>
        /// The date on which an academic program ends.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "endOn")]
        [FilterProperty("criteria")]
        public DateTimeOffset? EndDate { get; set; }

         /// <summary>
        /// The starting academic period of student's enrollment in the program.
        /// </summary>
        [DataMember(Name = "academicPeriod", EmitDefaultValue = false)]
        public GuidObject2 StartTerm { get; set; }

         /// <summary>
        /// The current state of a student's academic program enrollment.
        /// </summary>
        [DataMember(Name = "enrollmentStatus")]
        public EnrollmentStatusDetail EnrollmentStatus { get; set; }

        /// <summary>
        /// A measurement of the student's overall performance in the program (e.g. GPA).
        /// </summary>
        [DataMember(Name = "performanceMeasure", EmitDefaultValue = false)]
        public string PerformanceMeasure { get; set; }

        /// <summary>
        /// A list of academic recognitions the student has received.
        /// </summary>
        [DataMember(Name = "recognitions", EmitDefaultValue = false)]
        public List<GuidObject2> Recognitions { get; set; }
        /// <summary>
        /// The date the student graduate from the program
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "graduatedOn")]
        [FilterProperty("criteria")]
        public DateTimeOffset? GraduatedOn { get; set; }

        /// <summary>
        /// The date the student graduate from the program
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "credentialsDate")]
        public DateTimeOffset? CredentialsDate { get; set; }

        /// <summary>
        /// The title of the thesis (dissertation)
        /// </summary>
        [DataMember(Name = "thesisTitle", EmitDefaultValue = false)]
        public string ThesisTitle { get; set; }

        /// <summary>
        /// The number of credits earned at the home institution during the course of study for the program.
        /// </summary>
        [DataMember(Name = "creditsEarned", EmitDefaultValue = false)]
        public decimal? CreditsEarned { get; set; }
        

        /// <summary>
        /// Mapping a student to academic programs in which they are enrolled.
        /// </summary>
        public StudentAcademicPrograms_V7_0()
        {
            Program = new GuidObject2();
            Student = new GuidObject2();
            //Disciplines = new List<StudentAcademicProgramDisciplines>();
            EnrollmentStatus = new EnrollmentStatusDetail();
        }
    }
}