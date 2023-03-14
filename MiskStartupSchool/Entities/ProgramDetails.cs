using MiskStartupSchool.Enums;

namespace MiskStartupSchool.Entities
{
    public class ProgramDetails
    {
        public ProgramType ProgramType { get; set; }
        public DateTime ProgramStart { get; set; }
        public DateTime ApplciationOpen { get; set; }
        public DateTime ApplicationClose { get; set; }
        public int Duration { get; set; }
        public string ProgramLocation { get; set; }
        public MinQualifications MinQualification { get; set; }

    }
}
