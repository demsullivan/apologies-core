using ApologiesCore.Commands;

namespace ApologiesCore.Cards
{
    class EightCard : ICard {
        public static CardValue Value {
            get {
                return CardValue.Eight;
            }
        }

        public BaseCommand[] Commands {
            get {
                return new BaseCommand[] { new MoveForward(Value) };
            }
        }
    }
}