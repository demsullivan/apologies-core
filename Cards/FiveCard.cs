using ApologiesCore.Commands;

namespace ApologiesCore.Cards
{
    class FiveCard : ICard
    {
        public static new CardValue Value = CardValue.Five;

        public BaseCommand[] Commands
        {
            get
            {
                return new BaseCommand[] {new MoveForward(Value)};
            }
        }
    }
}