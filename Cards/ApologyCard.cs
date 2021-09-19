using ApologiesCore.Commands;

namespace ApologiesCore.Cards
{
    class ApologyCard : ICard {
        public static new CardValue Value = CardValue.Sorry;
        
        public BaseCommand[] Commands
        {
            get
            {
                return new BaseCommand[] { new Apology() };
            }
        }
    }
}

