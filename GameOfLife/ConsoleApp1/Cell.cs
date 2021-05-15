using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
#pragma warning disable
    [Serializable]
    class Cell
    {
        public uint coordinateX;
        public uint coordinateY;
        public bool alive {  get; private set; }
        public Cell(uint x,uint y,bool alive) 
        {
            coordinateX = x;
            coordinateY = y;
            this.alive = alive;
        }
        public void kill()
        {
            alive = false;
        }
        public void reborn()
        {
            alive = true;
        }
        static public bool operator ==(Cell left, Cell right)
        {
            if (left.alive == right.alive) return true;
            return false;
        }
        static public bool operator !=(Cell left, Cell rigth)
        {
            return !(left == rigth);
        }
    }
#pragma warning restore
}
