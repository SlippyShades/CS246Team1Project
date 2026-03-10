using CS246Team1Project.Models;

namespace CS246Team1Project.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<StudentModel>> GetAllAsync();
        Task<StudentModel?> GetByIdAsync(int id);
        Task<StudentModel> AddAsync(StudentModel student);
        Task<StudentModel> UpdateAsync(StudentModel student);
        Task<bool> DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task SaveChangesAsync();
    }
}