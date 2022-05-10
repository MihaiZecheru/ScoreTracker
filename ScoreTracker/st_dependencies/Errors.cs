namespace st_dependencies
{
    public class Errors
    {

        public static void ExecutionModeInvalid()
        {
            Console.WriteLine($"{Commands.dl}\n** Invalid First Argument **\n\nFirst argument should be:\n\t- help\n\t- add\n\t- remove\n\t- check (or \"see\", \"show\", \"list\")\n\t- app\n{Commands.dl}");
        }

        public static void NameMissing()
        {
            Console.WriteLine($"{Commands.dl}\n** Missing Second Argument **\n\nThe first argument given requires additional arguments to execute. You are missing the \"name\" argument.\nThe \"name\" argument must be one of the following strings:\n\t- chris\n\t- daria\n{Commands.dl}");
        }

        public static void NameInvalid()
        {
            Console.WriteLine($"{Commands.dl}\n** Invalid Second Argument **\n\nThe second argument given is known as the \"name\" argument. The \"name\" argument must be one of the following strings:\n\t- chris\n\t- daria\n{Commands.dl}");
        }

        public static void AmountInvalid()
        {
            Console.WriteLine($"{Commands.dl}\n** Invalid Third Argument **\n\nThe third argument given is known as the \"amount\" argument. The \"amount\" argument must be a number ≥ 1\n{Commands.dl}");
        }

        public static void Check_TooManyArguments()
        {
            Console.WriteLine($"{Commands.dl}\n** Too Many Arguments **\n\nThe command \"check\" only takes 1 optional argument of \"name\"\n{Commands.dl}");
        }

        public static void App_TooManyArguments()
        {
            Console.WriteLine($"{Commands.dl}\n** Too Many Arguments **\n\nThe command \"app\" takes no arguments\n{Commands.dl}");
        }
    }
}
