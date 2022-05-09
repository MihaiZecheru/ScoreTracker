using st_dependencies;

/* 
    execution_mode can be "add", "remove", "check" / "see" / "show" / "list", or "app"
        - add will take a second argument of "name" which is either "chris" or "daria",
            - and an optional third argument of "amount" which is a number
                - if the optional third argument of "amount" is not given, "amount" will default to the value of 1
            - the command will then add "amount" points to the given "name"

        - remove will take a second argument of "name" which is either "chris" or "daria",
            - and an optional third argument of "amount" which is a number
                - if the optional third argument of "amount" is not given, "amount" will default to the value of 1
            - the command will then remove "amount" points from the given "name"

        - check / see / "show" / "list" will take an optional second argument of "name" which is either "chris" or "daria",
            - if the optional second argument of "name" is given, the amount of points for "name" will be shown
            - if no optional second argument of "name" is given, the amount of points for both "chris" and "daria" will be shown

        - app will open up a GUI for this application with options for "add", "remove", and "check" / "see" / "show" / "list"
*/

namespace ScoreTrackerConsole
{
    public class ScoreTracker
    {
        public static readonly string dl = "\n-------------------------------------------------------------------------------------------------------------------\n";
        private static readonly string infoMessage = "\n" + dl + "\nexecution mode can be \"add\", \"remove\", \"check\" / \"see\" / \"show\" / \"list\", or \"app\"\n\t- add will take a second argument of \"name\" which is either \"chris\" or \"daria\",\n\t\t- and an optional third argument of \"amount\" which is a number\n\t\t\t- if the optional third argument of \"amount\" is not given, \"amount\" will default to the value of 1\n\t\t- the command will then add \"amount\" points to the given \"name\"\n\n\t- remove will take a second argument of \"name\" which is either \"chris\" or \"daria\",\n\t\t- and an optional third argument of \"amount\" which is a number\n\t\t\t- if the optional third argument of \"amount\" is not given, \"amount\" will default to the value of 1\n\t\t- the command will then remove \"amount\" points from the given \"name\"\n\n\t- check / see / \"show\" / \"list\" will take an optional second argument of \"name\" which is either \"chris\" or \"daria\",\n\t\t- if the optional second argument of \"name\" is given, the amount of points for \"name\" will be shown\n\t\t- if no optional second argument of \"name\" is given, the amount of points for both \"chris\" and \"daria\" will be shown\n\n\t- app will open up a GUI for this application with options for \"add\", \"remove\", and \"check\" / \"see\" / \"show\" / \"list\"\n" + dl;
        public static void Main(string[] args)
        {
            Console.Clear();

            if (args.Length == 0 || args.Length > 3)
            {
                Console.WriteLine($"{dl}\n\t\t\t\t\t  ** INCORRECT USAGE **\n\n\t\t  Correct Usage: ./st <execution_mode> [between 0-2 additional args]");
                Console.WriteLine(infoMessage);
                return;
            }

            if (args.Length >= 1)
            {
                RunCommand(args);
            }
        }

        private static void RunCommand(string[] args)
        {
            int amount = 1;

            switch (args[0])
            {
                case "help":
                case "--help":
                    Console.WriteLine(infoMessage);
                    break;

                case "add":
                    /* name is required, amount is optional */

                    // if name argument not provided
                    if (args.Length < 2)
                    {
                        Errors.NameMissing();
                        return;
                    }

                    // check if user gave the optional "amount" argument
                    if (args.Length == 3)
                    {
                        bool isValid = int.TryParse(args[2], out amount);

                        if (!isValid || amount < 1)
                        {
                            Errors.AmountInvalid();
                            return;
                        }
                    }

                    if (args[1].ToLower() != "chris" && args[1].ToLower() != "daria" && args[1].ToLower() != "both")
                    {
                        Errors.NameInvalid();
                        return;
                    }

                    bool add_result = Commands.Add(args[1].ToLower(), amount).Result;
                    HandleOperationResult(add_result);
                    break;

                case "remove":
                    /* name is required, amount is optional */

                    // if name argument not provided
                    if (args.Length < 2)
                    {
                        Errors.NameMissing();
                        return;
                    }

                    // check if user gave the optional "amount" argument
                    if (args.Length == 3)
                    {
                        bool isValid = int.TryParse(args[2], out amount);

                        if (!isValid || amount < 1)
                        {
                            Errors.AmountInvalid();
                            return;
                        }
                    }

                    if (args[1].ToLower() != "chris" && args[1].ToLower() != "daria" && args[1].ToLower() != "both")
                    {
                        Errors.NameInvalid();
                        return;
                    }

                    bool remove_result = Commands.Remove(args[1].ToLower(), amount).Result;
                    HandleOperationResult(remove_result);
                    break;

                case "check":
                case "see":
                case "show":
                case "list":
                    /* name is optional */

                    if (args.Length > 2)
                    {
                        Errors.Check_TooManyArguments();
                        return;
                    }

                    if (args.Length == 2)
                    {
                        // make sure "name" argument is valid
                        if (args[1].ToLower() != "chris" && args[1].ToLower() != "daria" && args[1].ToLower() != "both")
                        {
                            Errors.NameInvalid();
                            return;
                        }

                        bool check_result = Commands.Check(args[1].ToLower()).Result;
                        HandleOperationResult(check_result);
                        return;
                    }

                    bool result = Commands.Check().Result;
                    HandleOperationResult(result);
                    break;

                case "app":
                    /* this command takes no arguments */

                    if (args.Length > 1)
                    {
                        Errors.App_TooManyArguments();
                    }

                    Commands.App();
                    break;

                default:
                    Errors.ExecutionModeInvalid();
                    break;
            }
        }

        private static void HandleOperationResult(bool result)
        {
            string indent = "\t\t\t\t\t\t";

            if (result)
                Console.WriteLine($"{dl}\n{indent}Operation Successful\n{dl}");
            else
                Console.WriteLine($"{dl}\n{indent}Operation Unsuccessful\n{dl}");
        }
    }
}