namespace Multiplayer.Common
{
    public static class MpVersion
    {
        public const string Version = "0.5.0.26"; // this is copied to About.xml via workshop_bundler.sh
        public const int Protocol = 18;

        public const string apiAssemblyName = "0MultiplayerAPI";
        public const string compatibilityModId = "rwmt.multiplayercompatibility";

#if DEBUG
        public const bool IsDebug = true;
#else
        public const bool IsDebug = false;
#endif
    }
}
