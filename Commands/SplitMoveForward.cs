using System;
using ApologiesCore.Cards;
using System.Collections.Generic;

namespace ApologiesCore.Commands
{
    class SplitMoveForward : BaseCommand
    {
        public CardValue CardValue;
        private IPlayerToken m_FirstPlayerToken;
        private IPlayerToken m_SecondPlayerToken;

        private int m_FirstTokenMoveCount = 0;
        private int m_SecondTokenMoveCount = 0;

        public SplitMoveForward(CardValue value)
        {
            CardValue = value;
        }
        
        new List<CommandInputType> NeededInput()
        {
            int totalMoves = (int) CardValue;
            
            List<CommandInputType> inputs = new List<CommandInputType>();

            if (m_FirstPlayerToken == null)
            {
                inputs.Add(CommandInputType.PLAYER_TOKEN);
            }

            if (m_FirstTokenMoveCount == 0)
            {
                inputs.Add(CommandInputType.NUMBER);
            }

            if (m_FirstTokenMoveCount < totalMoves && m_SecondPlayerToken == null)
            {
                inputs.Add(CommandInputType.PLAYER_TOKEN);
            } 
            else if (m_FirstTokenMoveCount < totalMoves)
            {
                inputs.Add(CommandInputType.NUMBER);    
            }

            return inputs;
        }

        new void AddInput<T>(CommandInputType input, T inputValue)
        {
            if (inputValue is IPlayerToken)
            {
                if (m_FirstPlayerToken == null)
                {
                    m_FirstPlayerToken = (IPlayerToken) inputValue;
                }
                else
                {
                    m_SecondPlayerToken = (IPlayerToken) inputValue;
                }
            }

            // if (inputValue is int)
            // {
            //     if (m_FirstTokenMoveCount == 0)
            //     {
            //         m_FirstTokenMoveCount = (int) inputValue;
            //     }
            //     else
            //     {
            //         m_SecondTokenMoveCount = (int) inputValue;
            //     }
            // }
        }

        new void Execute(Board board)
        {
            if (NeededInput().Count > 0)
            {
                return;
            }

            board.MoveToken(m_FirstPlayerToken, m_FirstTokenMoveCount);

            if (m_SecondPlayerToken != null)
            {
                board.MoveToken(m_SecondPlayerToken, m_SecondTokenMoveCount);
            }
        }
    }
}