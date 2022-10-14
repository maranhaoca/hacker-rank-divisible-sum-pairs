using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        //Arrange
        int n = 6;
        int k = 5;
        List<int> ar = new List<int>(){1, 2, 3, 4, 5, 6};

        var expected = 3;        

        //Act
        var actual = Result.divisibleSumPairs(n, k, ar);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        //Arrange
        int n = 6;
        int k = 3;
        List<int> ar = new List<int>(){1, 3, 2, 6, 1, 2};

        var expected = 5;        

        //Act
        var actual = Result.divisibleSumPairs(n, k, ar);

        //Assert
        Assert.Equal(expected, actual);
    }
}