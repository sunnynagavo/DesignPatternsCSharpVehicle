namespace DesignPatterns.Core.Interfaces
{
    /// <summary>
    /// Interface for Engine object
    /// </summary>
    public interface IEngine
    {
        int Size { get; }
        bool Turbo { get; }

        // for the purpose of bridge pattern we are adding below methods
        void Start();
        void Stop();
        void IncreasePower();
        void DecreasePower();
    }
}
