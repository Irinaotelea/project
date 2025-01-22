public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Email: {Email}";
    }
}
