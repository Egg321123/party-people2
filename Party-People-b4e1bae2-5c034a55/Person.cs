using System.Text.Json;
public class Person
{
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public int? age { get; set; }
    public string Introduction()
    {
            return $"Name: {firstName}, LastName: {lastName}, Age: {age}";
    }
}
