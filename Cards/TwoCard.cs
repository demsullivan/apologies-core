using ApologiesCore.Commands;

namespace ApologiesCore.Cards
{
    class TwoCard : ICard {
        public static new CardValue Value = CardValue.Two;

        public BaseCommand[] Commands
        {
            get
            {
                return new BaseCommand[] {
                    new MoveForward(Value), 
                    new LeaveStart()
                }; 
            }
        }
    }
}