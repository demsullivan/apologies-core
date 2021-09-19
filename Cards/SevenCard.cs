using ApologiesCore.Commands;

namespace ApologiesCore.Cards
{
    class SevenCard : ICard {
        public static new CardValue Value = CardValue.Seven;
        public BaseCommand[] Commands
        {
            get
            {
                return new BaseCommand[] {new SplitMoveForward(Value) };
            }
        }
    }
}

