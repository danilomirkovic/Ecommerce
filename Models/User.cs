namespace bend;

public class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
    public enum Type
    { 
        SuperAdmin,
        StoreAdmin,
        User
    }
}
