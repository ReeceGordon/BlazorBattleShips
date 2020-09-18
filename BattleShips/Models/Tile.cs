using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShips.Models
{
    public class Tile
    {
        public char X { get; set; }
        public int Y { get; set; }
        public int ShipSpace { get; set; } //0 == No ship, 1 == BattleShip, 2 == Duncan, 3 == Defender, 4 == Hit
    }
}
