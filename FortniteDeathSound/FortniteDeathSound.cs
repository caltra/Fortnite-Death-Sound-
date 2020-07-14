using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;



namespace FortniteDeathSound
{
    class ForniteDeathSound : Mod
    {

        public class MyPlayer : ModPlayer
        {
            // Removes vanilla death sound.
            public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
            {
                playSound = false;
                return true;
            }
            // Adds Fortnite death sound. Link to sound: https://www.youtube.com/watch?v=la2tCfiXZYw
            public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.position.X, (int)player.position.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/DeathSoundEffect"));
            }
        }

    }
}