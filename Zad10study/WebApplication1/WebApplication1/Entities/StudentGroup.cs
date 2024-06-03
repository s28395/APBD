namespace WebApplication1.Entities;
//Entities
public class StudentGroup
{
    public int IdStudent { get; set; }
    public int IdGroup { get; set; }
    public DateTime CreatedAt { get; set; }
    public virtual Student Student { get; set; }
    public virtual Group Group { get; set; }
}