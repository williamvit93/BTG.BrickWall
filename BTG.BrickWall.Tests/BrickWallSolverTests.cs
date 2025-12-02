using BTG.BrickWall.Domain;

namespace BTG.BrickWall.Tests;

using System.Collections.Generic;
using Xunit;

public class BrickWallSolverTests
{
    private readonly BrickWallSolver _solver;

    public BrickWallSolverTests()
    {
        _solver = new BrickWallSolver();
    }

    [Fact]
    public void LeastBricks_ExampleInput_Returns2()
    {
        // Arrange
        var wall = new List<IList<int>>
        {
            new List<int>{1,2,2,1},
            new List<int>{3,1,2},
            new List<int>{1,3,2},
            new List<int>{2,4},
            new List<int>{3,1,2},
            new List<int>{1,3,1,1}
        };

        // Act
        int result = _solver.LeastBricks(wall);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void LeastBricks_OneBrickPerRow_MustCutAllBricks()
    {
        // Arrange
        var wall = new List<IList<int>>
        {
            new List<int>{5},
            new List<int>{5},
            new List<int>{5}
        };

        // Act
        int result = _solver.LeastBricks(wall);

        // Assert
        // Não há bordas internas, qualquer linha no meio corta todos os tijolos
        Assert.Equal(3, result);
    }

    [Fact]
    public void LeastBricks_AllRowsSamePattern_ReturnsZero()
    {
        // Arrange
        var wall = new List<IList<int>>
        {
            new List<int>{2,3,1},
            new List<int>{2,3,1},
            new List<int>{2,3,1}
        };

        // Act
        int result = _solver.LeastBricks(wall);

        // Assert
        // Todas as bordas internas estão alinhadas, dá pra passar a linha somente nas bordas
        Assert.Equal(0, result);
    }
}
