using ApologiesCore.Commands;

namespace ApologiesCore.Cards
{
    class ThreeCard : ICard {
    public static new CardValue Value = CardValue.Three;
    public BaseCommand[] Commands
    {
        get
        {
            return new BaseCommand[] {new MoveForward(Value)};
        }
    }
}
}