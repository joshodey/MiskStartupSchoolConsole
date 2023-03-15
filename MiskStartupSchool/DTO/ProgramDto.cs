using MiskStartupSchool.Enums;

namespace MiskStartupSchool.DTO
{
    public class ProgramDto
    {
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
    }
}
