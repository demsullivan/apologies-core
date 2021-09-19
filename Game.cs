using ApologiesCore.Cards;
using ApologiesCore.Commands;
using System.Collections.Generic;

namespace ApologiesCore
{

    enum PlayerColor
    {
        RED,
        BLUE,
        GREEN,
        YELLOW
    };
    
    // Game is responsible for setting up all of the elements of the game, managing
    // communication between the various elements, and enforcing the basic rules.

    // Deck is responsible for managing draw and discard piles, drawing new cards,
    // and re-shuffling the deck.

    // Player is responsible for owning tokens, ...?

    // Board is responsible for knowing what tiles exist and in what order, and 
    // the behaviour of special tiles like slides, safety zones,
    // start points, and homes.

    class Game {
        private List<IPlayer> m_Players = new List<IPlayer>();
        private Board m_Board;
        private Deck m_Deck;
        private IPlayer m_ActivePlayer;

        public Game(List<IPlayer> players) {
            m_Players = players;
            m_Deck = new Deck();
            m_Board = new Board(m_Players);
            m_ActivePlayer = m_Players[0];
        }

        public void PerformCurrentTurn() {
            ICard nextCard = m_Deck.Draw();

            m_ActivePlayer.OnCardDrawn(nextCard);

            if (nextCard.Commands.Length > 1) {
                m_ActivePlayer.CommandDecision(nextCard.Commands, (BaseCommand command) => ExecuteCommand(command));
            } else {
                ExecuteCommand(nextCard.Commands[0]);
            }
        }

        // actual game logic here
        public void ExecuteCommand(BaseCommand baseCommand) {
            baseCommand.SetPlayer(m_ActivePlayer);

            // if (!baseCommand.CanExecute(m_Board))
            // {
            //     return;
            // }
        
            List<CommandInputType> input = baseCommand.NeededInput();
            if (input.Count > 0) {
                m_ActivePlayer.GetCommandInput(baseCommand, (BaseCommand cmd) => ExecuteCommand(cmd));
            }

            baseCommand.Execute(m_Board);
        }
    }
}