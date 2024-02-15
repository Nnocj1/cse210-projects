public class Activity
{
    private string _name;
    private int _activityLength;
    private string _description;

    public Activity(string name , string activityInfo) // This is also for setting the activity length's value.
    {
        _description = activityInfo;
        _name = name;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}\n");
        Console.WriteLine(_description);
        Console.WriteLine("How long in seconds will you like for your session?");
        string userDuration = Console.ReadLine();
        int duration = int.Parse(userDuration);
        _activityLength = duration;

        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You have completed the {_name} in {_activityLength} seconds.")
    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

    }
}