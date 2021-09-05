using System;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace BigscreenExampleMod
{
    public class MainMod : MelonMod
    {
        // Equiv of MonoBehaviour OnUpdate()
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                MelonLogger.Log("Woah, thats cool. You just pressed the letter T on your keyboard!");
            }
        }

        // A harmony patch.
        // This patch targets Assets.Scripts.AppInitializer - It will add a little bit of our code into the method.
        [HarmonyPatch(typeof(Assets.Scripts.AppInitializer), "Initialize")]
        class MyHarmonyPatch
        {
            public static void Patch()
            {
                MelonLogger.Log("If you are reading this! Hello from a Harmony Patch @ Assets.Scripts.AppInitializer!");
            }
        }
    }
}
