namespace FixTutorialPosition
{
    using MEC;
    using PlayerRoles;
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    using UnityEngine;

    public class EventHandlers
    {
        [PluginEvent(ServerEventType.PlayerChangeRole)]
        public void OnChangingRole(Player player, PlayerRoleBase oldRole, RoleTypeId newRole, RoleChangeReason reason)
        {
            if (newRole.GetTeam() == Team.OtherAlive)
            {
                Timing.CallDelayed(0.1f, () => player.Position = new Vector3(40.297f, 1014.110f, -31.918f));
                return;
            }
        }
    }
}
