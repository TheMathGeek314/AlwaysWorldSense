using System.Collections.Generic;
using UnityEngine;
using Modding;

namespace AlwaysWorldSense {
    public class AlwaysWorldSense: Mod {
        new public string GetName() => "AlwaysWorldSense";
        public override string GetVersion() => "1.0.0.0";
        public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects) {
            ModHooks.NewGameHook += grantWorldSense;
            ModHooks.SavegameLoadHook += onLoadGame;
        }

        private void onLoadGame(int obj) {
            grantWorldSense();
        }

        private void grantWorldSense() {
            PlayerData.instance.unlockedCompletionRate = true;
        }
    }
}