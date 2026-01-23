using System;

namespace Code.Architecture.Mechanics {
    public interface IBank {
        float GetCoinsCurrent();

        event Action<float> Decrease;
        event Action<float> Increase;
        event Action<float, float> CoinsChanged;
    }
}