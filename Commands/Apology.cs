using ApologiesCore.Cards;
using System.Collections.Generic;

namespace ApologiesCore.Commands
{
    class Apology : BaseCommand
    {
        private IPlayer m_Player;
        private IPlayerToken m_OpponentToken;
        
        /* NOTE: this only applies if the player that drew the card
         * has tokens left in start.
         */
        
        public List<CommandInputType> NeededInput()
        {
            List<CommandInputType> inputs = new List<CommandInputType>();

            if (m_OpponentToken == null)
            {
                inputs.Add(CommandInputType.COMPETITOR_TOKEN);
            }

            return inputs;
        }

        public void SetPlayer(IPlayer player)
        {
            m_Player = player;
        }

        public void AddInput<T>(CommandInputType input, T inputValue)
        {
            if (inputValue is IPlayerToken)
            {
                m_OpponentToken = (IPlayerToken) inputValue;
            }
        }

        public void Execute(Board board)
        {
            if (NeededInput().Count > 0)
            {
                return;
            }
            
            // execute.
        }
    }
}