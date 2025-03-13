using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Splines;

namespace ImmerzaSDK
{
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
