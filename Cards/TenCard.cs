using ApologiesCore.Commands;

namespace ApologiesCore.Cards
{
    class TenCard : ICard {
        public static new CardValue Value = CardValue.Ten;
        public BaseCommand[] Commands
        {
            get
            {
                return new BaseCommand[] {new MoveForward(Value), new MoveBackward(1) };
            }
        }
        
    }
}
