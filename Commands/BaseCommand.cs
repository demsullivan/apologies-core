using ApologiesCore.Cards;
using System.Collections.Generic;

namespace ApologiesCore.Commands
{
    enum CommandInputType {
        PLAYER_TOKEN,
        COMPETITOR_TOKEN,
        NUMBER
    }

    class BaseCommand
    {
        protected IPlayer m_Player;

        public List<CommandInputType> NeededInput()
        {
            return new List<CommandInputType>();
        }

        public void SetPlayer(IPlayer player)
        {
            m_Player = player;
        }

        public void AddInput<T>(CommandInputType input, T inputValue)
        {
            
        }

        public void Execute(Board board)
        {
            
        }
    }
}