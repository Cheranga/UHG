namespace UHG.Puzzles.TrianglePuzzle
{
    public class EquilateralTriangle : ITriangleCriteria
    {
        public TriangleType TriangleType
        {
            get { return TriangleType.Equilateral; }
        }

        bool ITriangleCriteria.IsValid(Triangle triangle)
        {
            return triangle != null &&
                   triangle.IsValid() &&
                   (triangle.SideA == triangle.SideB && triangle.SideB == triangle.SideC);
        }
    }
}