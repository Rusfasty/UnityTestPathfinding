using System.Collections.Generic;
using UnityEngine;
using System;

namespace Code.Architecture.Patterns.State {
    public class Context {
        private IState _stateCurrent;

        private Dictionary<Type, IState> _states;

        public void Update() => _stateCurrent.Update();

        public void Add<T>(T IState) { }
        public void Set<T>() { }
        public void Remove<T>() { }
    }
}