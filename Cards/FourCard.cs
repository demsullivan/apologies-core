using ApologiesCore.Commands;

namespace ApologiesCore.Cards
{
    class FourCard : ICard 
    {
        public static new CardValue Value = CardValue.Four;
        public BaseCommand[] Commands
        {
            get
            {
                return new BaseCommand[] {new MoveForward(Value)};
            }
        }
    }
}