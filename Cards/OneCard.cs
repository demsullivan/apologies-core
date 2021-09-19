using ApologiesCore.Commands;

namespace ApologiesCore.Cards
{
    class OneCard : ICard 
    {
        public static new CardValue Value = CardValue.One;
        public BaseCommand[] Commands
        {
            get
            {
                return new BaseCommand[] {new MoveForward(Value), new LeaveStart() };
            }
        }
    }
}
