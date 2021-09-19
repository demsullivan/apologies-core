using System.Collections.Generic;

using ApologiesCore.Cards;
using ApologiesCore.Tiles;

namespace ApologiesCore {
    class Board {

        enum TileType {
            NORMAL,
            SLIDE,
            SAFETY_ZONE_ENTRY,
            SAFETY_ZONE,
            START
        }

        public static Tile[] tiles = new Tile[60]
        {
            new Tile(),
            new SlideTile(3, PlayerColor.RED),
            new SafetyZoneTile(PlayerColor.RED), // branch off to safety zone
            new Tile(),
            new StartTile(PlayerColor.RED), // start
            new Tile(),
            new Tile(),
            new Tile(),
            new Tile(),
            new SlideTile(4, PlayerColor.RED),
            new Tile(),
            new Tile(),
            new Tile(),
            new Tile(),
            new Tile(),

            new Tile(),
            new SlideTile(3, PlayerColor.BLUE),
            new SafetyZoneTile(PlayerColor.BLUE), // branch off to safety zone
            new Tile(),
            new StartTile(PlayerColor.BLUE), // start
            new Tile(),
            new Tile(),
            new Tile(),
            new Tile(),
            new SlideTile(4, PlayerColor.BLUE),
            new Tile(),
            new Tile(),
            new Tile(),
            new Tile(),
            new Tile(),

            new Tile(),
            new SlideTile(3, PlayerColor.YELLOW),
            new SafetyZoneTile(PlayerColor.YELLOW), // branch off to safety zone
            new Tile(),
            new StartTile(PlayerColor.YELLOW), // start
            new Tile(),
            new Tile(),
            new Tile(),
            new Tile(),
            new SlideTile(4, PlayerColor.YELLOW),
            new Tile(),
            new Tile(),
            new Tile(),
            new Tile(),
            new Tile(),

            new Tile(),
            new SlideTile(3, PlayerColor.GREEN),
            new SafetyZoneTile(PlayerColor.GREEN), // branch off to safety zone
            new Tile(),
            new StartTile(PlayerColor.GREEN), // start
            new Tile(),
            new Tile(),
            new Tile(),
            new Tile(),
            new SlideTile(4, PlayerColor.GREEN),
            new Tile(),
            new Tile(),
            new Tile(),
            new Tile(),
            new Tile(),
        };

        // slide: you can't slide on your own slides
        // sliding knocks opponents back home
        // landing on a same spot knocks opponents back home
        private List<IPlayer> m_Players;
        public Board(List<IPlayer> players)
        {
            m_Players = players;
        }

        public void MoveToken(IPlayerToken token, int count)
        {
            if (token.Position + count > tiles.Length)
            {
                token.Position = (token.Position + count) - tiles.Length;
            }
            else
            {
                token.Position += count;    
            }
            
            
            Tile currentTile = tiles[token.Position];

            // TODO: delegate actions based on tile type
            // actions:
            // if slide tile of opponent color, 
            // move ahead X spaces + send any 
            // opponents back to start.
            //
            // if safety zone tile of your color,
            // next spaces to move to will be inside
            // the safety zone.
            //
            // if player token is already on the current
            // tile, send them back to start
        }
    }
}