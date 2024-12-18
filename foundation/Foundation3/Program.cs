

class Program
{
    static void Main(string[] args)
    {
        //Visual Studio suggested this shortcut for entering new activities into the List!
        List<Activity> activities =
        [
            new Running(new DateTime(2024, 10, 11), 40, 4.0),
            new Biking(new DateTime(2024, 10, 12), 75, 28.0),
            new Swimming(new DateTime(2024, 10, 13), 45, 32),
        ];

        //display summary for every activity in list
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
