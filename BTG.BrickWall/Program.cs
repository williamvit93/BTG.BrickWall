using BTG.BrickWall.Domain;

var wall = new List<IList<int>> 
{
    new List<int>{1,2,2,1},
    new List<int>{3,1,2},
    new List<int>{1,3,2},
    new List<int>{2,4},
    new List<int>{3,1,2},
    new List<int>{1,3,1,1}
};

BrickWallSolver solver = new BrickWallSolver();
int result = solver.LeastBricks(wall);

Console.WriteLine(result);