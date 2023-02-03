public class Database
{
    public IEnumerable<User> Users = new User[]{
        new User{
            Id=1,
            FirstName= "Mohsen",
            LastName="Bazmi",
            BirthDate = DateTime.Now.AddYears(-30),
            Email = "Mohsen@example.com",
            PhoneNumber = "1234567890"
        }
    };
}