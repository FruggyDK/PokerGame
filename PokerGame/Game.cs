namespace PokerGame
{
    internal class Game
    {
        enum RoundType
        {
            PreFlop,
            Flop,
            Turn,
            River,
            Showdown
        }

        enum TurnOptions
        {
            Hit,
            Stand
        }

        private RoundType roundType = RoundType.PreFlop;

        public void Run()
        {
            switch (roundType)
            {
                case RoundType.PreFlop:

                    break;
            }
        }
    }
}
