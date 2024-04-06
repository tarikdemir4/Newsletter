namespace Newsletter.Domain.Entities;

public sealed class Subscribe
{
    public Subscribe()
    {
        Id= Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string EmailConfirmed  { get; set; } 
}