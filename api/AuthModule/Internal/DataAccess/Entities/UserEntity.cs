namespace AuthModule.Internal.DataAccess.Entities;

internal class UserEntity
{
    public DateTime CreatedAt { get; set; }

    public DateTime ModifiedAt { get; set; }

    public string Name { get; set; }

    public string PasswordHash { get; set; }

    public string PasswordSalt { get; set; }
}