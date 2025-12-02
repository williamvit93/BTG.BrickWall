namespace BTG.BrickWall.Domain;

public class BrickWallSolver
{
    public int LeastBricks(IList<IList<int>> wall)
    {
        Dictionary<int, int> edgeCount = new Dictionary<int, int>();
        int maxEdgesAligned = 0;

        foreach (var row in wall)
        {
            int position = 0;

            for (int i = 0; i < row.Count - 1; i++)
            {
                position += row[i];

                if (!edgeCount.ContainsKey(position))
                    edgeCount[position] = 0;

                edgeCount[position]++;

                maxEdgesAligned = Math.Max(maxEdgesAligned, edgeCount[position]);
            }
        }

        return wall.Count - maxEdgesAligned;
    }
}