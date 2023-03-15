using MiskStartupSchool.Entities;
using MiskStartupSchool.Enums;

namespace MiskStartupSchool.DTO
{
    public class ApplicationDto
    {
        public string ImageUrl { get; set; }
        public string ResumeUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public string Residence { get; set; }
        public string IDNumber { get; set; }
        public Gender Gender { get; set; }
        public string ProgramTitle { get; set; }
        public string ProgramSummary { get; set; }
        public string ProgramDescription { get; set; }
        public string KeySkills { get; set; }
        public string ProgramBenefits { get; set; }
        public string ApplicationCriteria { get; set; }
        public ProgramType ProgramType { get; set; }
        public DateTime ProgramStart { get; set; }
        public DateTime ApplciationOpen { get; set; }
        public DateTime ApplicationClose { get; set; }
        public int Duration { get; set; }
        public string ProgramLocation { get; set; }
        public MinQualifications MinQualification { get; set; }
        public int MaxApplications { get; set; }
        public ICollection<Education> Educations { get; set; }
        public ICollection<Experience> Experiences { get; set; }
        public ICollection<InterviewQuestions> Questions { get; set; }
        public ICollection<Stage> stages { get; set; }
    }
}
