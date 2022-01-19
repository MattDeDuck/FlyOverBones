using BepInEx;

namespace FlyOverBones
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, "1.0.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }

        public void Update()
        {
            if (Managers.RecipeMap.indicator.dangerZoneIds.Count > 0)
            {
                foreach (var item in Managers.Player.inventory.items)
                {
                    if (item.Key.name == "Potion of Necromancy, Necromancy, Necromancy, Fly, Fly" || item.Key.name == "Potion of Fly, Fly, Necromancy, Necromancy, Necromancy")
                    {
                        Managers.RecipeMap.indicator.health = 1f;
                    }
                }
            }
        }
    }
}
