using LOopOop.Debugging;

namespace LOopOop
{
    public class LOopOopConsts
    {
        public const string LocalizationSourceName = "LOopOop";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "b51503a6b5fc410f8f82556977d34733";
    }
}
