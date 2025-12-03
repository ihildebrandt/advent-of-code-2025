namespace Common
{
    public static class Input
    {
        public static string GetInputPath(int day, bool test)
        {
            return GetInputPath(day, test ? "testinput.txt" : "input.txt");
        }

        public static string GetInputPath(int day, string file)
        {
            var path = $"%USERPROFILE%/source/repos/ihildebrandt/advent-of-code-2025/input/{day:D2}/{file}";
            return Environment.ExpandEnvironmentVariables(path);

        }
    }
}
