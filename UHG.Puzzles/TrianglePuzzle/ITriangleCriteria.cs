namespace UHG.Puzzles.TrianglePuzzle
{
    public interface ITriangleCriteria
    {
        TriangleType TriangleType { get; }
        bool IsValid(Triangle triangle);
    }
}