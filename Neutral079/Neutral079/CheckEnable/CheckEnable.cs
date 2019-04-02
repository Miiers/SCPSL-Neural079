using Smod2;
using Smod2.Attributes;
using Smod2.EventHandlers;
using Smod2.Events;

namespace Neutral079.CheckEnable
{
    [PluginDetails(author = "Miiers", name = "Neural079", description = "", id = "Neural079", version = "1.0", SmodMajor = 3, SmodMinor = 1, SmodRevision = 7)]
    internal class @event : Plugin
    {
        public override void OnDisable()
        {
            base.Info("Neural079 is not run now");
        }

        public override void OnEnable()
        {
            base.Info("Neural079 is Enable");
        }

        public override void Register()
        {
            this.AddEventHandlers(new CheckRun.CheckRun(this));
            this.AddConfig(new Smod2.Config.ConfigSetting("n079_Enable", true, Smod2.Config.SettingType.BOOL, true, "Neural079 plugin Enable/Disable"));
            this.AddConfig(new Smod2.Config.ConfigSetting("n079_MaxAP", 110, Smod2.Config.SettingType.NUMERIC, true, "Neural079 MaxAP(default:110)"));
            this.AddConfig(new Smod2.Config.ConfigSetting("n079_APPer", 2, Smod2.Config.SettingType.NUMERIC, true, "Neural079 Power recovery speed(default:2)"));
            this.AddConfig(new Smod2.Config.ConfigSetting("n079_LC", 3, Smod2.Config.SettingType.NUMERIC, true, "Neural079 can lockdown count(default:3)"));
            this.AddConfig(new Smod2.Config.ConfigSetting("n079_LD", 50, Smod2.Config.SettingType.NUMERIC, true, "Neural079 lockdown die probability(default:50%)"));
        }
    }
}