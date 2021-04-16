using System.Dynamic;

namespace CustomControls
{
    public class Controls
    {
        #region Application Information

        public static dynamic GetApplicationInfo()
        {
            dynamic appInfo = new ExpandoObject();

#if DEBUG
            appInfo.Build = "Debug";
#else
            appInfo.Build = "Release";
#endif

            appInfo.Name = typeof(Controls).Assembly.GetName().Name;
            appInfo.Version = typeof(Controls).Assembly.GetName().Version.ToString();

            return appInfo;
        }

        #endregion
    }


}
