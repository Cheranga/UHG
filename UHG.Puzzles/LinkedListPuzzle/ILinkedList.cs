namespace UHG.Puzzles.LinkedListPuzzle
{
    public interface ILinkedList<T>
    {
        ILinkedList<T> Add(T item);

        T GetNthElement(int elementAt);

        T this[int index] { get; }
    }
}