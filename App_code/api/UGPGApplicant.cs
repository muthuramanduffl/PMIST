using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UGPGApplicant
/// </summary>

[Serializable]
public class UGPGApplicant
{
    public string ApplicationNo { get; set; }
    public string AppliedFor { get; set; }
    public string ApplicantName { get; set; }
    public string MobileNo { get; set; }
    public string EmailId { get; set; }
    public string Gender { get; set; }
    public string DateOfBirth { get; set; }
    public string MotherTongue { get; set; }
    public string Nationality { get; set; }
    public string BloodGroup { get; set; }
    public string Community { get; set; }
    public string Religion { get; set; }
    public string MotherName { get; set; }
    public string FatherName { get; set; }
    public string CommunicationAddress { get; set; }
    public string PermanentAddress { get; set; }
    public string ParentOccupation { get; set; }
    public string PatentAnnualIncome { get; set; }
    public string CutOffMarks { get; set; }
    public string EligibilityMarks { get; set; }
    public string NATAScore { get; set; }
    public string UNIGAUGEScore { get; set; }
    public string HostelRequirement { get; set; }
    public string AchievementInSport { get; set; }
    public string AchievementSportName { get; set; }
    public string AchievementSportLevel { get; set; }
    public string AchievementSportMedalist { get; set; }
    public string PaymentMode { get; set; }
    public string Fee { get; set; }
    public string CashPaymentBillNo { get; set; }
    public string CashPaymentBillDate { get; set; }
    
    public string SSLCSchoolName { get; set; }
    public string SSLCBoard { get; set; }
    public string SSLCMediumOfInstruction { get; set; }
    public string SSLCRegistrationNo { get; set; }
    public string SSLCNoOfAttempts { get; set; }
    public string SSLCMonthAndYearOfPassing { get; set; }
    public string SSLCPercentageOfMarks { get; set; }

    public string HSCSchoolName { get; set; }
    public string HSCBoard { get; set; }
    public string HSCMediumOfInstruction { get; set; }
    public string HSCRegistrationNo { get; set; }
    public string HSCNoOfAttempts { get; set; }
    public string HSCMonthAndYearOfPassing { get; set; }
    public string HSCPercentageOfMarks { get; set; }

    public string AppliedDate { get; set; }
    
    public HSCMark[] HSCSubjectMarks { get; set; }

    public UGPGApplicant()
    {
        this.HSCSubjectMarks = new HSCMark[0];
    }
}