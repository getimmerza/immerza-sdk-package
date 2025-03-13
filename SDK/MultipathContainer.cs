using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Splines;
using XLua;

namespace ImmerzaSDK
{
    [LuaCallCSharp]
    public class MultipathContainer : MonoBehaviour
    {
        [SerializeField] private List<SplineContainer> paths;

        public SplineContainer GetRandomPath()
        {
            int pathIndex = Random.Range(0, paths.Count);

            return paths[pathIndex];
        }
    }
}
