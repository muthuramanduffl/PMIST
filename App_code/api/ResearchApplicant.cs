using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ResearchApplicant
/// </summary>
public class ResearchApplicant
{
    public string ApplicationNo { get; set; }
    public string AppliedFor { get; set; }
    public string Branch { get; set; }
    public string ResearchArea { get; set; }
    public string ModeOfStudy { get; set; }

    public string ApplicantName { get; set; }
    public string Gender { get; set; }
    public string DateOfBirth { get; set; }
    public string PlaceOfBirth { get; set; }
    public string PresentAddress { get; set; }
    public string PermanentAddress { get; set; }
    public string District { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
    public string MobileNo { get; set; }
    public string EmailId { get; set; }
    public string TelephoneNo { get; set; }
    public string Nationality { get; set; }
    public string Caste { get; set; }
    public string Community { get; set; }
    public string Religion { get; set; }
    public string MotherTongue { get; set; }
    public string BloodGroup { get; set; }
    public string MaitalStatus { get; set; }
    public string DifferentlyAbledPerson { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public string CountryInWhichQualified { get; set; }
    public string PresentAnnualIncome { get; set; }
    public string HostelRequired { get; set; }
    public string SponsorCandidate { get; set; }
    public string TypeOfEmployment { get; set; }
    public string NatureOfWork { get; set; }
    public string NameOfTheEmployer { get; set; }
    public string TotalExperience { get; set; }
    public string AverageIncome { get; set; }
    public string PaperPublished { get; set; }
    public string AadhaarNo { get; set; }
    public string PaymentMode { get; set; }
    public string Fee { get; set; }
    public string CashPaymentBillNo { get; set; }
    public string CashPaymentBillDate { get; set; }

    public string AppliedDate { get; set; }

    public Education[] EducationDetails { get; set; }
    public ProfessionalExperience[] ProfessionalExperiences { get; set; }

    public ResearchApplicant()
    {
        this.EducationDetails = new Education[0];
        this.ProfessionalExperiences = new ProfessionalExperience[0];
    }
}