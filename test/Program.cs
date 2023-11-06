using test;

public class MainDemo
{
    public static void Main(string[] args)
    {
        var data = new Users();
        foreach (var item in data.getUsers())
        {
            Console.WriteLine(item.Name+" "+item.age.ToString());
        }
    }
}