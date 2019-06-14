using System;

using R5T.NetStandard.OS.Extensions;


namespace R5T.NetStandard.OS
{
    public class MachineName : TypedString
    {
        #region Static

        /// <summary>
        /// Gets the <see cref="Environment.MachineName"/> value.
        /// </summary>
        public static MachineName Environment()
        {
            var executingMachineName = System.Environment.MachineName.AsMachineName();
            return executingMachineName;
        }

        #endregion


        public MachineName(string value)
            : base(value)
        {
        }
    }
}
