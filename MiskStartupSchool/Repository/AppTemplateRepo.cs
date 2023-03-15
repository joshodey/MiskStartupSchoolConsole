using Microsoft.EntityFrameworkCore;
using MiskStartupSchool.Context;
using MiskStartupSchool.DTO;
using MiskStartupSchool.Services;

namespace MiskStartupSchool.Repository
{
    public class AppTemplateRepo : IAppTemplate
    {
        private readonly ApplicationDbContext _context;

        public AppTemplateRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<AppTemplateDto> GetTemplate(string Id)
        {
            var data = await _context.application.FirstOrDefaultAsync(x => x.ApplicationId == Id);
            if (data == null) return null;

            return new AppTemplateDto()
            {
                Educations = data.Educations,
                IDNumber = data.IDNumber,
                Email = data.Email,
                Experiences = data.Experiences,
                FirstName = data.FirstName,
                LastName = data.LastName,
                Gender = data.Gender,
                ImageUrl = data.ImageUrl,
                Nationality = data.Nationality,
                Phone = data.Phone,
                Residence = data.Residence,
                ResumeUrl = data.ResumeUrl
            };
        }

        public async Task<bool> UpdateTemplate(AppTemplateDto program, string Id)
        {
            var data = await _context.application.FirstOrDefaultAsync(x => x.ApplicationId == Id);

            if (data == null) return false;

            data.IDNumber = program.IDNumber;
            data.Email = program.Email;
            data.FirstName = program.FirstName;
            data.LastName = program.LastName;
            data.Gender = program.Gender;
            data.ImageUrl = program.ImageUrl;
            data.Nationality = program.Nationality;
            data.Phone = program.Phone;
            data.Residence = program.Residence;
            data.ResumeUrl = program.ResumeUrl;
            data.Experiences = program.Experiences;
            data.Educations = program.Educations;

            _context.Update(data);
            return _context.SaveChanges() > 0;
        }
    }
}
