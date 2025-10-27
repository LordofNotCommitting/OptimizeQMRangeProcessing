using HarmonyLib;
using MGSC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace OptimizeQMRangeProcessing
{
    [HarmonyPatch(typeof(BallisticSystem), nameof(BallisticSystem.CreateBallistic))]
    public class LimitRange
    {
        //steam mod ID 3594238447
        //mod_updateworkshopitem 3594238447 C:\Users\Edgar\source\repos\OptimizeQMRangeProcessing\OptimizeQMRangeProcessing\src\bin\Debug\net48 thumbnail.png
        static void Postfix(ref Ballistic __result)
        {
            //Plugin.Logger.Log("--- Range Optimizing applied");
            if (__result.MaxDistance == -1)
            {
                __result.MaxDistance = 30;
            }
        }
    }
}
