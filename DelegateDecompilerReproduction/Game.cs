using DelegateDecompiler;
using Microsoft.Extensions.Internal;

namespace DeletegateDecompilerRepro
{
    public enum GameState
    {
        NotStarted = 0,
        Started = 1,
    }
    public class Game
    {
        public int Id { get; set; }
        public DateTimeOffset? Start { get; set; }

        [Computed]
        public GameState State()
        {
            if (Start == null)
            {
                return GameState.NotStarted;
            }
            else
            {
                return GameState.Started;
            }
        }
    }
}
