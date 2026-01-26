namespace CleanMediatR.Domain.Entities
{
    public class EmployeeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
