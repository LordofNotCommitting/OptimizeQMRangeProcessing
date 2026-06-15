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
    [HarmonyPatch(typeof(BallisticSystem), nameof(BallisticSystem.Next))]
    public class ProjectileSpeedUp
    {
        public static void Prefix(MapGrid mapGrid, ref Ballistic ballistic, bool hitWall)
        {
            //Plugin.Logger.Log("--- Range Optimizing applied");
            //To speed of 0.02f. which is 1/50. 50 is current fastest projectile speed as of right now.
            if (ballistic.PassedDistance > 10)
            {
                ballistic.PassTileDuration = 0.02f;
            }
        }
    }



}
