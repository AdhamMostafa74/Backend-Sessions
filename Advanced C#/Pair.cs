namespace Advanced_C_;

internal class Pair <TKey, TValue>(TKey key, TValue value)
{
    /*
     Question 3 

    a multiople generic type parameters are classes that can use more than one type 
    to allow more complex data structures and relationships such as tuples and dictionaries

     */

    public TKey key = key;
    public TValue value = value;
}
