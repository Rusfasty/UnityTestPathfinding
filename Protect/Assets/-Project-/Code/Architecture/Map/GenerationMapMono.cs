using UnityEngine;

namespace Code.Architecture.Map {
    public class GenerationMapMono : MonoBehaviour {
        [field: SerializeField] public MapMono Map { get; private set; }

        public void Creat(int X,int Y) {

        }
        public void Init() {
            Map = new(4, 2);
        }
    }
}
