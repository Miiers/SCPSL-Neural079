using System;
using Smod2.API;
using Smod2.Events;
using Smod2.EventHandlers;
using Smod2;

namespace Neutral079.CheckRun
{
    internal class CheckRun : IEventHandler, IEventHandler079LevelUp, IEventHandlerSpawn, IEventHandler079Lockdown, IEventHandlerPlayerDie, IEventHandlerRoundEnd, IEventHandlerGeneratorEjectTablet, IEventHandlerGeneratorUnlock, IEventHandlerCheckRoundEnd, IEventHandlerRoundRestart
    {
        private Plugin plugin;
        private int scp079id = -1;
        private int count = 0;
        private bool neutralSpawn = true;
        private int neutralMaxAP;
        private int neutralAPPer;
        private bool neutralEnable;
        private int Neutral079LockdownCount;
        private int Neutral079LockdownDead;

        public CheckRun(Plugin plugin)
        {
            this.plugin = plugin;
        }

        public void OnSpawn(PlayerSpawnEvent ev)
        {
            neutralEnable = plugin.GetConfigBool("n079_Enable");
            if (ev.Player.TeamRole.Role == Role.SCP_079 && neutralSpawn == true && neutralEnable == true)
            {
                scp079id = ev.Player.PlayerId;
                neutralSpawn = false;
            }
        }

        public void On079LevelUp(Player079LevelUpEvent ev)
        {
            neutralMaxAP = plugin.GetConfigInt("n079_MaxAP");
            neutralAPPer = plugin.GetConfigInt("n079_APPer");
            ev.Player.Scp079Data.MaxAP.Equals(neutralMaxAP);
            ev.Player.Scp079Data.APPerSecond.Equals(neutralAPPer);
        }

        public void On079Lockdown(Player079LockdownEvent ev)
        {
            Neutral079LockdownCount = plugin.GetConfigInt("n079_LC");
            Neutral079LockdownDead = plugin.GetConfigInt("n079_LD");
            if (count > Neutral079LockdownCount)
            {
                if (new Random().Next(1, 100) > Neutral079LockdownDead)
                {
                    ev.Player.Kill(DamageType.TESLA);
                }
            }
            else
            {
                count++;
            }
        }

        public void OnGeneratorEjectTablet(PlayerGeneratorEjectTabletEvent ev)
        {
            ev.Allow = false;
        }

        public void OnGeneratorUnlock(PlayerGeneratorUnlockEvent ev)
        {
            ev.Allow = false;
        }

        public void OnPlayerDie(PlayerDeathEvent ev)
        {
            if (ev.Player.PlayerId == scp079id)
            {
                scp079id = -1;
                neutralSpawn = true;
            }
        }

        public void OnCheckRoundEnd(CheckRoundEndEvent ev)
        {
            if (scp079id != -1)
            {
                int check = 0;
                int check2 = 0;
                int check3 = 0;
                int check4 = 0;
                int check5 = 0;
                foreach (Player player in plugin.pluginManager.Server.GetPlayers())
                {
                    if (player.TeamRole.Team == Team.SCP)
                    {
                        check++;
                    }
                    if (player.TeamRole.Team == Team.CHAOS_INSURGENCY)
                    {
                        check2++;
                    }
                    if (player.TeamRole.Team == Team.SCIENTIST)
                    {
                        check3++;
                    }
                    if (player.TeamRole.Team == Team.CLASSD)
                    {
                        check4++;
                    }
                    if (player.TeamRole.Team == Team.NINETAILFOX)
                    {
                        check5++;
                    }
                }
                if ((check2 == 0 && check4 == 0 && check == 1) && !neutralSpawn)
                {
                    ev.Status = ROUND_END_STATUS.MTF_VICTORY;
                    plugin.pluginManager.Server.Round.EndRound();
                    return;
                }
                if ((check3 == 0 && check5 == 0 && check == 1 && check2 >= 1) && !neutralSpawn)
                {
                    ev.Status = ROUND_END_STATUS.CI_VICTORY;
                    plugin.pluginManager.Server.Round.EndRound();
                }
            }
        }

        public void OnRoundEnd(RoundEndEvent ev)
        {
            neutralSpawn = true;
            scp079id = -1;
            count = 0;
        }

        public void OnRoundRestart(RoundRestartEvent ev)
        {
            neutralSpawn = true;
            scp079id = -1;
            count = 0;
        }
    }
}