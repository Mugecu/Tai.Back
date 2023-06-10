namespace Estimations.Domain.Guards
{
    internal static class Guard
    {
        internal static void CheckTextOnMaxLength(string input, string message)
        {
            int maxInputSimbol = 1000;
            if(input.Length > maxInputSimbol)
                throw new Exception(message);
        }
    }
}
