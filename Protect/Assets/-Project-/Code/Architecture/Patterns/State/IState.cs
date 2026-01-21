using UnityEngine;

namespace Code.Architecture.Patterns.State {
    public interface IState {
        void Entry();
        void Update();
        void Exit();
    }
}