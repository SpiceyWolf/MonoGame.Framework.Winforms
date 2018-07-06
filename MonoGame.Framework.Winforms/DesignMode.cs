namespace VisualStudio
{
    internal static class DesignMode
    {
        private static bool _active;
        private static bool _initialized;

        /// <summary>
        /// If running in Visual Studio, will return true.
        /// </summary>
        public static bool Active
        {
            get
            {
                if (!_initialized)
                {
                    _active =
                        System.ComponentModel.LicenseManager.UsageMode ==
                        System.ComponentModel.LicenseUsageMode.Designtime ||
                        System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv";
                    _initialized = true;
                }
                return _active;
            }
        }
    }
}