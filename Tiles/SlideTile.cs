namespace ApologiesCore.Tiles
{
    class SlideTile : Tile
    {
        private int m_Length;
        private PlayerColor m_Color;
        public SlideTile(int length, PlayerColor color)
        {
            m_Length = length;
            m_Color = color;
        }

        public int Length {
            get { return m_Length; }
        }

        public PlayerColor Color {
            get { return m_Color; }
        }
    }
}