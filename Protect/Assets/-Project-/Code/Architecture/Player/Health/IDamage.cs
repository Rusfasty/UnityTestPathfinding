namespace Code.Architecture.Player.Healths {
    public interface IDamage {
        void TakeDamage(float amount);

        void Kill();
    }
}