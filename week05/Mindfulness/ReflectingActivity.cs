public class ReflectingActivity : Activity
{
    private List<string> _prompts = new() {
        "Think of a time when you overcame a challenge...",
        "Think of something you're grateful for..."
    };

    private List<string> _questions = new() {
        "Why was this experience meaningful?",
        "How did you feel after?"
    };

    public ReflectingActivity() 
        : base("Reflecting", "This activity will help you reflect on moments in your life.") { }

    public void Run()
    {
        StartActivity();
        Console.WriteLine(_prompts[new Random().Next(_prompts.Count)]);
        ShowSpinner(5);

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine(_questions[new Random().Next(_questions.Count)]);
            ShowSpinner(5);
        }

        EndActivity();
    }
}
