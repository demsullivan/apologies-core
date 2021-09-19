using ApologiesCore.Commands;

namespace ApologiesCore.Cards
{
    class TwelveCard : ICard
    {
        public static new CardValue Value = CardValue.Twelve;
        public BaseCommand[] Commands
        {
            get
            {
                return new BaseCommand[] {new MoveForward(Value)};
            }
        }
    }
}