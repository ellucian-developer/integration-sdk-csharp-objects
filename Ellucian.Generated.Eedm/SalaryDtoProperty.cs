// Copyright 2016-2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details of the salary associated with the job.
    /// </summary>
    [DataContract]
    public class SalaryDtoProperty
    {
        /// <summary>
        ///  The grade of salary for the job.
        /// </summary>
        [DataMember(Name = "grade", EmitDefaultValue = false)]
        public string Grade { get; set; }

        /// <summary>
        /// The step of salary for the job.
        /// </summary>
        [DataMember(Name = "step", EmitDefaultValue = false)]
        public string Step { get; set; }

        /// <summary>
        /// The amount of salary for the job.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public SalaryAmountDtoProperty SalaryAmount { get; set; }

        /// <summary>
        /// The start date associated with the salary
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "startOn", EmitDefaultValue = false)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The end date associated with the salary
        /// </summary>
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        [JsonConverter(typeof(DateOnlyConverter))]
        public DateTime? EndOn { get; set; }
    }
}