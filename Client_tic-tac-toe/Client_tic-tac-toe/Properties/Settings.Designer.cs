namespace Client_tic_tac_toe.Properties
{
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    [global::System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {
        private static Settings defaultInstance = (Settings)global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings());

        public static Settings Default => defaultInstance;

        [global::System.Configuration.UserScopedSetting]
        public string CurrentUser
        {
            get => (string)this[nameof(CurrentUser)];
            set => this[nameof(CurrentUser)] = value;
        }
    }
}
