using Microsoft.EntityFrameworkCore;
using MiskStartupSchool.Context;
using MiskStartupSchool.DTO;
using MiskStartupSchool.Entities;
using MiskStartupSchool.Enums;
using MiskStartupSchool.Services;

namespace MiskStartupSchool.Repository
{
    public class ApplicationRepo : IApplicationRepo
    {
        readonly ApplicationDbContext _context;

        public ApplicationRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Add(ApplicationDto application)
        {
            if (application == null) return null;

            try
            {
                var data = new ApplicationForm()
                {
                    ApplicationId = Guid.NewGuid().ToString(),
                    ImageUrl = application.ImageUrl,
                    ResumeUrl = application.ResumeUrl,
                    FirstName = application.FirstName,
                    LastName = application.LastName,
                    Email = application.Email,
                    Phone = application.Phone,
                    Nationality = application.Nationality,
                    Residence = application.Residence,
                    IDNumber = application.IDNumber,
                    Gender = application.Gender,
                    Educations = application.Educations,
                    Experiences = application.Experiences,
                    stages = application.stages,
                    ProgramType = application.ProgramType,
                    ProgramStart = application.ProgramStart,
                    ApplciationOpen = application.ApplciationOpen,
                    ApplicationClose = application.ApplicationClose,
                    Duration = application.Duration,
                    ProgramLocation = application.ProgramLocation,
                    MinQualification = application.MinQualification,
                    ProgramTitle = application.ProgramTitle,
                    ProgramSummary = application.ProgramSummary,
                    ProgramDescription = application.ProgramDescription,
                    KeySkills = application.KeySkills,
                    ProgramBenefits = application.ProgramBenefits,
                    ApplicationCriteria = application.ApplicationCriteria
                };

                await _context.AddAsync(data);
                var newdata = await _context.SaveChangesAsync();

                return newdata.ToString();
            }
            catch (DbUpdateException ex)
            {
                // Log the error details
               return ex.InnerException?.Message;
                //return false;
            }


            
        }

        public Task<ApplicationDto> Get()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(ApplicationDto application)
        {
            throw new NotImplementedException();
        }
    }
}
