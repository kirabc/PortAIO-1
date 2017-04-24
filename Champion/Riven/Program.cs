#region

using System;
using LeagueSharp;
using LeagueSharp.Common;
using EloBuddy;

#endregion

 namespace NechritoRiven
{
    public class Program
    {
       public static void Init()
        {
            Loading.OnLoadingComplete += GameLoaded;
        }

        private static void OnLoad(EventArgs args)
        {
            if (ObjectManager.Player.ChampionName != "Riven")
            {
                Chat.Print("Could not load Riven");
                return;
            }
           Load.Load.LoadAssembly();
         }
    }
}
