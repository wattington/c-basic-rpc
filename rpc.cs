using DiscordRPC; // on microsoft visual studio install the DiscordRichPresence

public class rpc
{
    static DiscordRpcClient client;

    static void Main(string[] args)
    {
        client = new DiscordRpcClient("");
         Console.WriteLine("Connected to discord");
        client.Initialize();

        client.SetPresence(new RichPresence()
        {
            Details = "",
            State = "",

            //Timestamps = new Timestamps
            //{
            //   Start = DateTime.UtcNow
            //}

        });
    }
}
