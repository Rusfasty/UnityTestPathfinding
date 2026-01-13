using Code.Architecture.Map.Point;
using System;
using UnityEngine;

namespace Code.Architecture.Map {
    [Serializable]
    public class MapMono {
        [field: SerializeField] public PointMono[] pointMonoX { get ; private set; }
        [field: SerializeField] public PointMono[] pointMonoY { get; private set; }

        public MapMono(int X,int Y) {
            pointMonoX = new PointMono[X];
            pointMonoY = new PointMono[Y];

            CreatePointMap(X,Y);
        }
        public void CreatePointMap(int X,int Y) {
        }

    }
}
