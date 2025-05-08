global using Color = Microsoft.Xna.Framework.Color;

using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.ModLoader;

namespace Fissure;
public class Fissure : Mod
{
    public static Fissure Instance => ModContent.GetInstance<Fissure>();
    public Fissure() => MusicSkipsVolumeRemap = true;
    public override void Load()
    {
        LoadEffects();
    }
    public static void LoadEffects()
    {
        static Asset<Effect> LoadEffect(string path) => ModContent.Request<Effect>("Fissure/Effects/" + path);
        // LoadEffect("whatever"); yeahhh
    }
}
