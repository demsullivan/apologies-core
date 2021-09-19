namespace ApologiesCore.Tiles
{
    class SafetyZoneTile : Tile
    {
        private PlayerColor m_Color;
        public SafetyZoneTile(PlayerColor color)
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