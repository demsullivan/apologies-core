using ApologiesCore.Commands;

namespace ApologiesCore.Cards
{
class ElevenCard : ICard {
    public static new CardValue Value = CardValue.Eleven;

    public BaseCommand[] Commands
    {
        get
        {
            return new BaseCommand[]
            {
                new MoveForward(Value),
                new SwapPlaces()
            };
        }
    }
}
}
