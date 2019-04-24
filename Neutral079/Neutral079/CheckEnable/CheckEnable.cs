using Smod2;
using Smod2.Attributes;
using Smod2.EventHandlers;
using Smod2.Events;

namespace Neutral079.CheckEnable
{
    [PluginDetails(author = "Miiers", name = "Neural079", description = "", id = "Neural079", version = "2.0")]
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
            this.AddConfig(new Smod2.Config.ConfigSetting("n079_Enable", true, true, "Neural079 plugin Enable/Disable"));
            this.AddConfig(new Smod2.Config.ConfigSetting("n079_MaxAP", 110, true, "Neural079 MaxAP(default:110)"));
            this.AddConfig(new Smod2.Config.ConfigSetting("n079_APPer", 2, true, "Neural079 Power recovery speed(default:2)"));
            this.AddConfig(new Smod2.Config.ConfigSetting("n079_LC", 3, true, "Neural079 can lockdown count(default:3)"));
            this.AddConfig(new Smod2.Config.ConfigSetting("n079_LD", 50, true, "Neural079 lockdown die probability(default:50%)"));
        }
    }
}