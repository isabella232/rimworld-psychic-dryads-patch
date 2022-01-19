using HarmonyLib;
using PsychicAnimals;
using RimWorld;
using Verse;

namespace Replace_Stuff_Compatibility.HarmonyPatches
{
	[HarmonyPatch(typeof(HelperClass), "CanBeAssignedToTrain")]
	public class PsychicDryads
	{
		static bool Prefix(ref bool __result, TrainableDef td, ThingDef animal)
		{
			if (td == TrainableDefOf.Release && animal.race.Dryad)
			{
				__result = true;
				return false;
			}

			return true;
		}
	}
}