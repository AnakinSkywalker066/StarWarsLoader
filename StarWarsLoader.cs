using BTD_Mod_Helper;
using Il2CppAssets.Scripts.Unity;
using MelonLoader;
using StarWarsLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(StarWarsLoader.Main), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace StarWarsLoader;

public class Main : BloonsTD6Mod
{
    [RegisterTypeInIl2Cpp]
    public class CloneSound : MonoBehaviour
    {
        public static void PlaySound(string name)
        {
            Game.instance.audioFactory.PlaySoundFromUnity(null, name, "FX", 1, 1);
        }
        public static void StopSound()
        {
            FindObjectOfType<AudioSource>().Stop();
        }
    }

}