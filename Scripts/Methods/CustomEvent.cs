namespace StudentMeter
{
    public class CustomEvent<T>
    {
        private event Action<T> Action = delegate
        { };

        public void Invoke(T parameter)
        {
            Action?.Invoke(parameter);
        }

        public void AddListener(Action<T> listener)
        {
            Action += listener;
        }

        public void RemoveListener(Action<T> listener)
        {
            Action -= listener;
        }
    }
}