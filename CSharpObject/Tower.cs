using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpObject
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;

        private static readonly System.Random _random = new System.Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                // Do stuff with invader
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    invader.DecreaseHealth(_power);
                    continue;
                }
            }
        }
    }
}
