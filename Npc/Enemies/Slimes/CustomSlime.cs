using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fmod.Npc.Enemies.Slimes
{
    class CustomSlime : ModNPC
    {
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 32;
            npc.aiStyle = 1;
            npc.damage = 400;
            npc.defense = 100;
            npc.lifeMax = 1000;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath16;
            npc.knockBackResist = 3f;
            npc.value = 1000000f;
            aiType = NPCID.BlueSlime;
            animationType = NPCID.BlueSlime;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDay.Chance * 2f;
        }
    }
}
