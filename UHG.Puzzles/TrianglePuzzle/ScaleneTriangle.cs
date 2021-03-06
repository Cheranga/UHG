﻿namespace UHG.Puzzles.TrianglePuzzle
{
    public class ScaleneTriangle : ITriangleCriteria
    {
        public TriangleType TriangleType
        {
            get { return TriangleType.Scalene; }
        }

        bool ITriangleCriteria.IsValid(Triangle triangle)
        {
            return triangle != null &&
                   triangle.IsValid() &&
                   (triangle.SideA != triangle.SideB && triangle.SideA != triangle.SideC && triangle.SideB != triangle.SideC);
        }
    }
}