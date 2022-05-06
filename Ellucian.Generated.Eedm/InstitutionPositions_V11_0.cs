// Copyright 2016-2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A detailed description of the positions at an institution.
    /// </summary>
    [DataContract]
    public class InstitutionPositions_V11_0 : BaseModel2
    {
        /// <summary>
        /// The code of the Institution Position (only for v11)
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The title of the Institution Position
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The description of the Institution Position.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The physical location of the Institution Position.
        /// </summary>
        [DataMember(Name = "campus", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public GuidObject2 Campus { get; set; }

        /// <summary>
        /// The operational units of the institution to which the position belongs
        /// </summary>
        [DataMember(Name = "departments", EmitDefaultValue = false)]
        public List<NameDetailDtoProperty> Departments { get; set; }

        /// <summary>
        /// The accounting strings associated with the position..
        /// </summary>
        [DataMember(Name = "accountingStrings", EmitDefaultValue = false)]
        public List<string> AccountingStrings { get; set; }

        /// <summary>
        /// The accounting strings associated with the position.
        /// </summary>
        [DataMember(Name = "accountingStringAllocations", EmitDefaultValue = false)]
        public List<AccountingStringAllocationsDtoProperty> AccountingStringAllocations { get; set; }

        /// <summary>
        /// The status of the position (e.g. active, frozen, cancelled, inactive).
        /// </summary>
        [DataMember(Name = "status")]
        [FilterProperty("criteria")]
        public PositionStatus? Status { get; set; }
             
        /// <summary>
        /// The number of hours of work in specified time periods.
        /// </summary>
        [DataMember(Name = "hoursPerPeriod", EmitDefaultValue = false)]
        public List<HoursPerPeriodDtoProperty> HoursPerPeriod { get; set; }

        /// <summary>
        /// The ratio of hours of work for the position to the hours of work expected of a full-time employee.
        /// </summary>
        [DataMember(Name = "fullTimeEquivalent", EmitDefaultValue = false)]
        public int FullTimeEquivalent { get; set; }

        /// <summary>
        /// The group or union associated with the position.
        /// </summary>
        [DataMember(Name = "bargainingUnit", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public GuidObject2 BargainingUnit { get; set; }
      
        /// <summary>
        /// The positions to which this position reports.
        /// </summary>
        [DataMember(Name = "reportsTo", EmitDefaultValue = false)]
        public List<ReportsToDtoProperty> ReportsTo { get; set; }

        /// <summary>
        /// An indicator if the position is exempt or non-exempt.
        /// </summary>
        [DataMember(Name = "exemptionType", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        public ExemptionType? ExemptionType { get; set; }

        /// <summary>
        /// The salary or wages awarded for the position.
        /// </summary>
        [DataMember(Name = "compensation", EmitDefaultValue = false)]
        public CompensationDtoProperty Compensation { get; set; }
     
        /// <summary>
        /// The date when the position is first available.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "startOn")]
        [FilterProperty("criteria")]
        public DateTime StartOn { get; set; }

        /// <summary>
        /// The date when the position is last available.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [FilterProperty("criteria")]
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// The date when the position is authorized.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "authorizedOn", EmitDefaultValue = false)]
        public DateTime? AuthorizedOn { get; set; }

        /// <summary>
        /// The employment classification associated with the position.
        /// </summary>
        [DataMember(Name = "classification", EmitDefaultValue = false)]
        public GuidObject2 Classification { get; set; }
    }
}