using System;
using MelonLoader;
using UnityEngine;

namespace BigscreenExampleMod
{
    public class MainMod : MelonMod
    {
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                MelonLogger.Log("Woah, thats cool. You just pressed the letter T on your keyboard!");
            }
        }
    }
}
