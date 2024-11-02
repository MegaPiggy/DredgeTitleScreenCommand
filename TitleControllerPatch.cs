using HarmonyLib;

namespace TitleScreenCommand
{
    [HarmonyPatch(typeof(TitleController), nameof(TitleController.Awake))]
    public static class TitleControllerPatch
    {
        public static void Prefix(TitleController __instance)
        {
            __instance.transform.parent.gameObject.AddComponent<TitleVisibilityManager>().titleScreenObject = __instance.gameObject;
        }
    }
}
