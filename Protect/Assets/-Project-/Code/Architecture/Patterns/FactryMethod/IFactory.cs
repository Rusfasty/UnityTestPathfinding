using UnityEngine;

namespace Code.Architecture.Patterns.FactoryMethod {
    public interface IFactory<T> {
        public T Create();
    }
}