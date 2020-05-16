using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD10.DTOs;
using APBD10.DTOs.Requests;
using APBD10.DTOs.Responses;

namespace APBD10.Services
{
    public interface IStudentsDbService
    {
        public IEnumerable<GetStudentsResponse> GetAllStudents();

        public Task<int> AddStudentAsync(InsertStudentRequest isq);
        public Task<int> AddStudiesAsync(InsertStudiesRequest isq);
        public Task<int> AddEnrollmentAsync(InsertEnrollmentRequest ieq);
        public Task<int> ModifyStudentAsync(UpdateStudentRequest usr);
        public Task<int> RemoveStudentAsync(string index);
        public Task<EnrollStudentResponse> EnrollStudentAsync(EnrollStudentRequest request);

        public Task<PromoteStudentResponse> PromoteStudentsAsync(PromoteStudentRequest promoteStudentRequest);

    }
}
