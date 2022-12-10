using BepInEx;
using CreatureManager;
using HarmonyLib;

namespace Dungeons
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class Plugin : BaseUnityPlugin
    {
        #region values
        private const string ModName = "TestFlyingMob", ModVersion = "1.0.0", ModGUID = "com.Frogger." + ModName;
        private static readonly Harmony harmony = new(ModGUID);
        public static Plugin _self;
        #endregion

        private void Awake()
        {
            _self = this;

            harmony.PatchAll();
        }

        #region Patch
        [HarmonyPatch]
        public static class Pacth
        {
            /*[HarmonyPatch(typeof(ZNetScene), nameof(ZNetScene.Awake)), HarmonyPostfix]
            public static void ZNetPatch(ZNetScene __instance)
            {
                if (SceneManager.GetActiveScene().name != "main") return;

            }*/
        }
        #endregion
        #region tools
        public void Debug(string msg)
        {
            Logger.LogInfo(msg);
        }
        public void DebugError(string msg)
        {
            Logger.LogError($"{msg} Write to the developer and moderator if this happens often.");
        }
        #endregion
    }
}