using ApologiesCore.Commands;

namespace ApologiesCore.Cards
{

    enum CardValue {
        One    = 1,
        Two    = 2,
        Three  = 3,
        Four   = 4,
        Five   = 5,
        Seven  = 7,
        Eight  = 8,
        Ten    = 10,
        Eleven = 11,
        Twelve = 12,
        Sorry  = 13
    }

    interface ICard {
        static CardValue Value {
            get;
        }
        BaseCommand[] Commands {
            get;
        }
    }
}
