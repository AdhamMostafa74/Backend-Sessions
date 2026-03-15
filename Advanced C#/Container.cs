using System.Numerics;

namespace Advanced_C_;


// Question 2

public class Container<T> where T : IComparable<T>
{
    public List<T> items = new();

    public Container(T[] items) => this.items = items;

    public void Add(T item) {
        items.Append(item);
    }
    public T Get() {
        foreach (T item in items) {
            return item;
        }
        return items[0];
    }

    //Question 5
    public T FindMax(T max)
    {
        foreach (T item in items) {
            if (max.CompareTo(item) > 0) {
                max = item;
            }
        }
        return max;
    }


    // QUESTION 14
    public T SafeList(int index) {
        foreach (T item in items)
        {
            if (index < 0 || index >= items.Count)
            {
                return default;
            }
        }
        return items[index];

    }

}
