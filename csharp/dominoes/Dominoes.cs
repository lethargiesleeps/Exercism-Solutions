using System;
using System.Collections.Generic;
using System.Linq;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes) => TestChain(dominoes.ToList(), (0, 0));

    public static bool TestChain(List<(int, int)> stones, (int first, int last) stoneNumbers)
    {
        if (stones.Count == 0 && stoneNumbers.first == stoneNumbers.last)
            return true;
        
    }
}