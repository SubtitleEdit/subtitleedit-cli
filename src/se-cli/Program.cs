using seconv;

var commandLineArgs = Environment.GetCommandLineArgs();
if (commandLineArgs.Length > 1)
{
    CommandLineConverter.ConvertOrReturn("Commandline-SE", commandLineArgs);
}
else
{
    Console.WriteLine("No parameters found - specify ´/help´ for help");
}