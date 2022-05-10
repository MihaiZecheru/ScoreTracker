using System.Reflection;
namespace st_dependencies
{
    public class Commands
    {
        public static readonly string dl = "\n-------------------------------------------------------------------------------------------------------------------\n";
        private static readonly string indent = "\t\t\t\t\t     ";

        public static async Task<bool> Add(string name, int amount)
        {
            Tuple<bool, string> response = await API.Put(name, amount);

            Console.WriteLine($"{dl}\n{indent}{response.Item2}");

            return response.Item1;
        }

        public static async Task<bool> Remove(string name, int amount)
        {
            Tuple<bool, string> response = await API.Put(name, amount - (amount * 2)); // convert amount to negative

            Console.WriteLine($"{dl}\n{indent}{response.Item2}");

            return response.Item1;
        }

        public static async Task<bool> Check(string name = "both")
        {
            Tuple<bool, string> response;
            string chatMessage;

            if (name == "chris" || name == "daria")
            {
                response = await API.Get(name);
                chatMessage = indent + response.Item2;
            }
            else // name is "both"
            {
                response = await API.Get("chris");
                chatMessage = indent + response.Item2;
                response = await API.Get("daria");
                chatMessage += "\n\n" + indent + response.Item2;
            }

            if (response.Item1)
                Console.WriteLine($"{dl}\n{chatMessage}");

            return response.Item1;
        }

        public static void App()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C \"..\\..\\..\\..\\ScoreTrackerApp\\bin\\Release\\net6.0-windows\\ScoreTrackerApp.exe\"";
            startInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            process.StartInfo = startInfo;
            process.Start();
        }
    }
}