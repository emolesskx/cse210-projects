public class ListingActivity : Activity
{
    private static readonly Random _random = new();

    private List<string> _prompts = new()
    {
        "List things that make you happy.",
        "List people who inspire you.",
        "List achievements you’re proud of.",
        "List places you want to visit.",
        "List things you’re grateful for."
    };

    public ListingActivity()
        : base("Listing", "This activity will help you focus on the positive by listing as many things as you can.") { }

    public void Run()
    {
        StartActivity();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine("You have some time to list as many items as you can.");
        Console.WriteLine("Start typing your responses now:\n");

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);
        List<string> responses = new();

        // Run until time expires
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        Console.WriteLine($"\nYou listed {responses.Count} item(s):");
        foreach (var item in responses)
        {
            Console.WriteLine($"- {item}");
        }

        EndActivity();
    }
}
