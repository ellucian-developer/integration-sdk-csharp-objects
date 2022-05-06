using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details of named grants, loans, scholarships, etc. 
    /// </summary>
    [DataContract]
    public class FinancialAidFunds_V9_1_0 : CodeItem2
    {    
       /// <summary>
       /// The source of the financial aid fund (federal, state, institutional, other).
       /// </summary>
          
       [DataMember(Name = "source", EmitDefaultValue = false)]
       public FinancialAidFundsSource Source { get; set; }
     
        /// <summary>
       /// Type of the financial aid fund (loan, grant, scholarship, work).
       /// </summary>
          
       [DataMember(Name = "aidType", EmitDefaultValue = false)]
       public FinancialAidFundsAidType AidType { get; set; }
     
        /// <summary>
       /// The classifications assigned to the financial aid fund.
       /// </summary>
          
       [DataMember(Name = "classifications", EmitDefaultValue = false)]
       public List<GuidObject2> Classifications { get; set; }
     
        /// <summary>
       /// Category of the financial aid fund.
       /// </summary>
          
       [DataMember(Name = "category", EmitDefaultValue = false)]
       public FinancialAidFundsCategoryProperty Category { get; set; }
     
        /// <summary>
       /// The privacy level of the financial aid fund based on privacy concerns (restricted, non-restricted). This indicates whether the award of this fund to a student is restricted or not for view.
       /// </summary>
          
       [DataMember(Name = "privacy", EmitDefaultValue = false)]
       public FinancialAidFundsPrivacy Privacy { get; set; }
     
        /// <summary>
       /// Financial details related to the financial aid fund by aid year and financial aid office.
       /// </summary>
          
       [DataMember(Name = "financials", EmitDefaultValue = false)]
       public List<FinancialAidFundsFinancialProperty> Financials { get; set; }
         
     }      
}          
