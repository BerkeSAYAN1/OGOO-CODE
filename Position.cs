using System;

public class Position
{
	public Position()
	{
		public int r { get; set; }
		public int s { get; set; }
		public char dir { get; set; }
   
	}
public void executeCommand(char command)
{
    char updateDirection = getUpdateDirection(command, position.getDir());
    int[] updatePosition;
    if (command == 'M')
    {
        updatePosition = getUpdateLocation(position.getR(), position.getC(), updateDirection);
        position.setR(updatePosition[0]);
        position.setC(updatePosition[1]);
    }
    position.setDir(updateDirection);
}
public char getUpdateDirection(char movement, char oldDirection)
{
    char updatedDir = matrix[moves.get(movement)][directions.get(oldDirection)];
    return updatedDir;
}
public SetNewPosition(int row, int column, char Direction, int length)
{
    switch (direction)
    {
        case 'N':
            row -= 1;
            break;
        case 'S':
            row += 1;
            break;
        case 'E':
            col += 1;
            break;
        case 'W':
            col -= 1;
            break;
    }
    if (row < 0 || col < 0 || row >= length || col >= length)
        throw new IllegalStateException("rover can not move");

    this.r = row;
    this.s = col;
}
}
