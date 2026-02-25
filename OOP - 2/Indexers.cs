using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___2;

public class Grades
{
    private List<int> _grades = new();

    // Indexer using an index (normal list access)
    public int this[int index]
    {
        get => _grades[index];
        set => _grades[index] = value;
    }

    // Indexer using a bool flag
    public int this[bool highest]
    {
        get
        {
            if (highest)
            {
                return _grades.Max();
            }
            else
            {
                return _grades.Min();
            }

        }
        }
}