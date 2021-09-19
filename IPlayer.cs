using System;

using ApologiesCore.Commands;
using ApologiesCore.Cards;

namespace ApologiesCore
{
    interface IPlayer {
        IPlayerToken[] PlayerTokens { 
            get;
        }
        void OnCardDrawn(ICard NextCard);
        BaseCommand CommandDecision(BaseCommand[] commands, Action<BaseCommand> Callback);
        void GetCommandInput(BaseCommand baseCommand, Action<BaseCommand> Callback);
    }
}