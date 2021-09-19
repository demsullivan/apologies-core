using ApologiesCore.Cards;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    public static class StackExtensions
    {
        public static Stack<T> Shuffle<T>(this Stack<T> stack) {
            Random rnd = new Random();
            return new Stack<T>(stack.OrderBy(x => rnd.Next()));
        }
    }
}

namespace ApologiesCore
{

    using Extensions;

    class Deck {
        private Stack<ICard> m_DrawPile = new Stack<ICard>();
        private Stack<ICard> m_DiscardPile = new Stack<ICard>();

        public Deck() {
            m_DiscardPile = GetDefaultCardStack();
            // } else {
            //     foreach(ICard card in cards) {
            //         m_DiscardPile.Push(card);
            //     }
            // }

            Reshuffle();
        }

        public ICard Draw() {
            return m_DrawPile.Pop();
        }

        public void Reshuffle() {
            m_DrawPile = m_DiscardPile.Shuffle();
            m_DiscardPile.Clear();
        }

        private Stack<ICard> GetDefaultCardStack() {
            Stack<ICard> newPile = new Stack<ICard>();

            // add five "1" cards to the discard pile
            foreach(var _ in Enumerable.Range(0, 4)) {
                newPile.Push(new OneCard());
            }

            // add four of each of the rest of the cards to the discard pile
            foreach(var _ in Enumerable.Range(0, 3)) {
                newPile.Push(new TwoCard());
                newPile.Push(new ThreeCard());
                newPile.Push(new FourCard());
                newPile.Push(new FiveCard());
                newPile.Push(new SevenCard());
                newPile.Push(new EightCard());
                newPile.Push(new TenCard());
                newPile.Push(new ElevenCard());
                newPile.Push(new TwelveCard());
                newPile.Push(new ApologyCard());
            }

            return newPile;
        }
    }
}