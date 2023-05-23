using System.Xml.Linq;

namespace TaiProgramms.Guards
{
    internal class Guard
    {
        public static void CheckStringOnNullOrEmpty(string input, string exceptionMessage)
        {
            if(string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                throw new Exception(exceptionMessage);
        }
    }
}
