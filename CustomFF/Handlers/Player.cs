using Exiled.Events.EventArgs;

namespace CustomFF.Handlers
{
    class Player
    {
        public void OnHurting(HurtingEventArgs ev)
        {
            // Checks if the attacker is allowed to hurt the target or if the target is cuffed and server disables harming cuffed enemies
            if (CustomFF.Instance.Config.DisabledDamage[ev.Attacker.Team].Contains(ev.Target.Team) || (ev.Target.IsCuffed && CustomFF.Instance.Config.DisableCuffedDamage))
            {
                ev.IsAllowed = false;
            }
        }
    }
}
