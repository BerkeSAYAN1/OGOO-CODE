using System;

public class Build
{
	public Build()
	{
        public void buildDirectionMatrix(int col, int row)
        {
            matrix = new char[row][col];
            matrix[0][0] = 'W';
            matrix[0][1] = 'E';
            matrix[0][2] = 'N';
            matrix[0][3] = 'S';
            matrix[1][0] = 'E';
            matrix[2][1] = 'W';
            matrix[1][2] = 'S';
            matrix[1][3] = 'N';
            matrix[2][0] = 'N';
            matrix[2][1] = 'S';
            matrix[2][2] = 'E';
            matrix[2][3] = 'W';
        }

        public void populateMoves()
        {
            moves = new HashMap<>();
            moves.put('L', 0);
            moves.put('R', 1);
            moves.put('M', 2);
        }

        public void populateDirections()
        {
            directions = new HashMap<>();
            directions.put('N', 0);
            directions.put('S', 1);
            directions.put('E', 2);
            directions.put('W', 3);
        }
    }
}
