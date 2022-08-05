using System.Collections.Generic;
public class Build
{
    public IDictionary<char, int> directions { get; set; }
    public IDictionary<char, int> moves { get; set; }
   
    public char[,] matrix;
    
    
    public Build()
	{

        
    }
    public void populateMoves()
    {
        moves = new Dictionary<char, int>();
        moves.Add('L', 0);
        moves.Add('R', 1);
        moves.Add('M', 2);
    }

    public void populateDirections()
    {
        directions = new Dictionary<char, int>();
        directions.Add('N', 0);
        directions.Add('S', 1);
        directions.Add('E', 2);
        directions.Add('W', 3);
    }
    public void buildDirectionMatrix(int col, int row)
    {
        matrix = new char[col, row];
        matrix[0, 0] = 'W';
        matrix[0, 1] = 'E';
        matrix[0, 2] = 'N';
        matrix[0, 3] = 'S';
        matrix[1, 0] = 'E';
        matrix[1, 1] = 'W';
        matrix[1, 2] = 'S';
        matrix[1, 3] = 'N';
        matrix[2, 0] = 'N';
        matrix[2, 1] = 'S';
        matrix[2, 2] = 'E';
        matrix[2, 3] = 'W';
    }
}
