#region

using System;
using LeagueSharp;
using LeagueSharp.Common;
using EloBuddy;
using EloBuddy.SDK.Events;

#endregion

 namespace NechritoRiven
{
    public class Program
    {
       static void Main(string[] args)
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
