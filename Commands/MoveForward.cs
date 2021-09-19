using ApologiesCore.Cards;
using System.Collections.Generic;

namespace ApologiesCore.Commands
{
    class MoveForward : BaseCommand {
        public CardValue CardValue;
        private IPlayerToken m_PlayerToken;

        public MoveForward(CardValue value) {
            CardValue = value;
        }

        new List<CommandInputType> NeededInput() {
            List<CommandInputType> inputs = new List<CommandInputType>();

            if (m_PlayerToken == null) {
                inputs.Add(CommandInputType.PLAYER_TOKEN);
            }

            return inputs;
        }

        new void AddInput<T>(CommandInputType input, T inputValue) {
            if (inputValue is IPlayerToken) {
                m_PlayerToken = (IPlayerToken)inputValue;
            }
        }

        new void Execute(Board board) {
            if (NeededInput().Count > 0) {
                return;
            }

            board.MoveToken(m_PlayerToken, (int)CardValue);
        }
    }
}