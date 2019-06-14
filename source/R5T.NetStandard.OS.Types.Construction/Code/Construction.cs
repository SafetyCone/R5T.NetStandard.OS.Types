using System;


namespace R5T.NetStandard.OS.Types.Construction
{
    public static class Construction
    {
        public static void SubMain()
        {
            Construction.GetCurrentMachineName();
        }

        private static void GetCurrentMachineName()
        {
            Console.WriteLine($"{nameof(Environment)}.{nameof(MachineName)}: {Environment.MachineName}");
        }
    }
}
