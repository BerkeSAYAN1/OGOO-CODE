using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OGOO_CODE
{
    class Position
    {
        public Position(int v1, int v2, char v3)
        {
            this.r = v1;
            this.s = v2;
            this.dir = v3;
        }
        

        public void getUpdateLocation(int row, int col, char direction)
        {
            switch (direction)
            {
                case 'N':
                    col += 1;
                    break;
                case 'S':
                    col -= 1;
                    break;
                case 'E':
                    row += 1;
                    break;
                case 'W':
                    row -= 1;
                    break;
                    
            }
            if (row < 0 || col < 0 || row > 5 || col > 5)
                throw new IllegalStateException("rover can not move");
            
            this.r = row;
            this.s = col;
        }

        public int KeyByValue(IDictionary<char, int> dict, char val)
        {
            char key = default;
            int value = 0;
            foreach (KeyValuePair<char, int> pair in dict)
            {
                if (EqualityComparer<char>.Default.Equals(pair.Key, val))
                {
                    value = pair.Value;
                    break;
                }
            }
            return value;
        }
        public char getUpdateDirection(char movement, char oldDirection, Build build)
        {
            char updatedDir = build.matrix[this.KeyByValue(build.moves, movement), this.KeyByValue(build.directions, oldDirection)];
            return updatedDir;
        }
        public int r { get; set; }
        public int s { get; set; }
        public char dir { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
