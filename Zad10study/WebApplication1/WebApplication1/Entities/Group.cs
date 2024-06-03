namespace WebApplication1.Entities;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<StudentGroup> StudentGroups { get; set; } = new List<StudentGroup>();
}