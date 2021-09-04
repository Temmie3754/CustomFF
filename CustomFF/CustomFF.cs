using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using System;

namespace CustomFF
{
    public class CustomFF : Plugin<Config>
    {
        private static CustomFF Singleton;
        public static CustomFF Instance => Singleton;
        public override string Author => "TemmieGamerGuy";
        public override string Name => "CustomFF";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(3, 0, 0);

        private Handlers.Player player;

        public void RegisterEvents()
        {
            player = new Handlers.Player();
            Player.Hurting += player.OnHurting;
        }

        public void UnregisterEvents()
        {
            Player.Hurting -= player.OnHurting;
            player = null;
        }

        public override void OnEnabled()
        {
            Singleton = this;
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            Singleton = null;
            base.OnDisabled();
        }
    }
}
