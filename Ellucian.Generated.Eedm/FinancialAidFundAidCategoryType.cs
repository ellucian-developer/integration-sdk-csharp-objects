// Copyright 2017-2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// Type of the financial aid fund categories.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidFundAidCategoryType
    {     
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
                     
        /// <summary>
        /// Pell Grant
        /// </summary>
        [EnumMember(Value = "pellGrant")]
        PellGrant,

        /// <summary>
        /// Federal Unsubsidized Loan
        /// </summary>
        [EnumMember(Value = "federalUnsubsidizedLoan")]
        FederalUnsubsidizedLoan,

        /// <summary>
        /// Federal Subsidized Loan
        /// </summary>
        [EnumMember(Value = "federalSubsidizedLoan")]
        FederalSubsidizedLoan,

        /// <summary>
        /// Graduate Teach Grant
        /// </summary>
        [EnumMember(Value = "graduateTeachGrant")]
        GraduateTeachGrant,

        /// <summary>
        /// Undergraduate Teach Grant
        /// </summary>
        [EnumMember(Value = "undergraduateTeachGrant")]
        UndergraduateTeachGrant,

        /// <summary>
        /// Parent Plus Loan
        /// </summary>
        [EnumMember(Value = "parentPlusLoan")]
        ParentPlusLoan,

        /// <summary>
        /// Graduate Plus Loan
        /// </summary>
        [EnumMember(Value = "graduatePlusLoan")]
        GraduatePlusLoan,

        /// <summary>
        /// Federal Work Study Program
        /// </summary>
        [EnumMember(Value = "federalWorkStudyProgram")]
        FederalWorkStudyProgram,

        /// <summary>
        /// Irag Afghanastan Service Grant
        /// </summary>
        [EnumMember(Value = "iraqAfghanistanServiceGrant")]
        IraqAfghanistanServiceGrant,

        /// <summary>
        /// Academic Competitiveness Grant
        /// </summary>
        [EnumMember(Value = "academicCompetitivenessGrant")]
        AcademicCompetitivenessGrant,

        /// <summary>
        /// Bureau of Indian Affairs Federal Grant
        /// </summary>
        [EnumMember(Value = "bureauOfIndianAffairsFederalGrant")]
        BureauOfIndianAffairsFederalGrant,

        /// <summary>
        /// Robert C Byrd Scholarship Program
        /// </summary>
        [EnumMember(Value = "robertCByrdScholarshipProgram")]
        RobertCByrdScholarshipProgram,

        /// <summary>
        /// Paul Douglas Teacher Scholarship
        /// </summary>
        [EnumMember(Value = "paulDouglasTeacherScholarship")]
        PaulDouglasTeacherScholarship,

        /// <summary>
        /// General Title IV Loan
        /// </summary>
        [EnumMember(Value = "generalTitleIVloan")]
        GeneralTitleIVloan,

        /// <summary>
        /// Health Education Assistance Loan
        /// </summary>
        [EnumMember(Value = "healthEducationAssistanceLoan")]
        HealthEducationAssistanceLoan,

        /// <summary>
        /// Health Professional Student Loan
        /// </summary>
        [EnumMember(Value = "healthProfessionalStudentLoan")]
        HealthProfessionalStudentLoan,

        /// <summary>
        /// Income Contingent Loan
        /// </summary>
        [EnumMember(Value = "incomeContingentLoan")]
        IncomeContingentLoan,

        /// <summary>
        /// Loan for Disadvantages Student
        /// </summary>
        [EnumMember(Value = "loanForDisadvantagesStudent")]
        LoanForDisadvantagesStudent,

        /// <summary>
        /// Leveraging Educational Assistance Partnership
        /// </summary>
        [EnumMember(Value = "leveragingEducationalAssistancePartnership")]
        LeveragingEducationalAssistancePartnership,

        /// <summary>
        /// National Health Services Corps Scholarship
        /// </summary>
        [EnumMember(Value = "nationalHealthServicesCorpsScholarship")]
        NationalHealthServicesCorpsScholarship,

        /// <summary>
        /// Nursing Student Loan
        /// </summary>
        [EnumMember(Value = "nursingStudentLoan")]
        NursingStudentLoan,

        /// <summary>
        /// Primary Care Loan
        /// </summary>
        [EnumMember(Value = "primaryCareLoan")]
        PrimaryCareLoan,

        /// <summary>
        /// Federal Perkins Loan
        /// </summary>
        [EnumMember(Value = "federalPerkinsLoan")]
        FederalPerkinsLoan,

        /// <summary>
        /// ROTC Scholarship
        /// </summary>
        [EnumMember(Value = "rotcScholarship")]
        RotcScholarship,

        /// <summary>
        /// Federal Supplementary Educational Opportunity Grant
        /// </summary>
        [EnumMember(Value = "federalSupplementaryEducationalOpportunityGrant")]
        FederalSupplementaryEducationalOpportunityGrant,

        /// <summary>
        /// Stay in School Program
        /// </summary>
        [EnumMember(Value = "stayInSchoolProgram")]
        StayInSchoolProgram,

        /// <summary>
        /// Federal Supplementary Loan for Parent
        /// </summary>
        [EnumMember(Value = "federalSupplementaryLoanForParent")]
        FederalSupplementaryLoanForParent,

        /// <summary>
        /// National Smart Grant
        /// </summary>
        [EnumMember(Value = "nationalSmartGrant")]
        NationalSmartGrant,

        /// <summary>
        /// States Student Incentive Grant
        /// </summary>
        [EnumMember(Value = "stateStudentIncentiveGrant")]
        StateStudentIncentiveGrant,

        /// <summary>
        /// VA Health Professionals Scholarship
        /// </summary>
        [EnumMember(Value = "vaHealthProfessionsScholarship")]
        VaHealthProfessionsScholarship,

        /// <summary>
        /// Non-Governmental
        /// </summary>
        [EnumMember(Value = "nonGovernmental")]
        NonGovernmental
    }
} 


