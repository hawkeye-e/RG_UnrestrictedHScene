using BepInEx.Configuration;
using BepInEx.IL2CPP;

namespace UnrestrictedHScene
{
    internal class Config
    {
        private const string GENERAL = "General";

        internal static bool Enabled { get { return _enabled.Value; } }
        private static ConfigEntry<bool> _enabled;


        internal static void Init(BasePlugin plugin)
        {
            _enabled = plugin.Config.Bind(GENERAL, "Enable this plugin", true, "If false, this plugin will do nothing (requires game restart)");
        }

    }
}
