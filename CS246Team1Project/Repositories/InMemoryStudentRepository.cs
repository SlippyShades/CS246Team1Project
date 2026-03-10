using CS246Team1Project.Models;

namespace CS246Team1Project.Repositories
{
    public class InMemoryStudentRepository : IStudentRepository
    {
        private readonly List<StudentModel> _students = new();
        private int _nextId = 1;

        public Task<IEnumerable<StudentModel>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<StudentModel>>(_students.ToList());
        }

        public Task<StudentModel?> GetByIdAsync(int id)
        {
            var student = _students.FirstOrDefault(s => s.LNumber == id);
            return Task.FromResult(student);
        }

        public Task<StudentModel> AddAsync(StudentModel student)
        {
            if (student.LNumber == 0)
            {
                student.LNumber = _nextId++;
            }
            _students.Add(student);
            return Task.FromResult(student);
        }

        public Task<StudentModel> UpdateAsync(StudentModel student)
        {
            var existing = _students.FirstOrDefault(s => s.LNumber == student.LNumber);
            if (existing != null)
            {
                _students.Remove(existing);
                _students.Add(student);
            }
            return Task.FromResult(student);
        }

        public Task<bool> DeleteAsync(int id)
        {
            var student = _students.FirstOrDefault(s => s.LNumber == id);
            if (student == null)
            {
                return Task.FromResult(false);
            }

            _students.Remove(student);
            return Task.FromResult(true);
        }

        public Task<bool> ExistsAsync(int id)
        {
            return Task.FromResult(_students.Any(s => s.LNumber == id));
        }

        public Task SaveChangesAsync()
        {
            return Task.CompletedTask;
        }

        // Helper method for testing - seed data
        public void SeedData(IEnumerable<StudentModel> students)
        {
            _students.Clear();
            _students.AddRange(students);
        }
    }
}