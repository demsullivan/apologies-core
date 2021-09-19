namespace ApologiesCore.Tiles
{
    class StartTile : Tile
    {
        private PlayerColor m_Color;

        public StartTile(PlayerColor color)
        {
            m_Color = color;
        }

        public void OnTokenLanded(IPlayerToken token)
        {
            
        }

        public void OnTokenLeaving(IPlayerToken token)
        {
            
        }
    }
}