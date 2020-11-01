using Terraria.ModLoader;

namespace Fmod
{
    class Fmod : Mod
    {
        public Fmod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
    }
}