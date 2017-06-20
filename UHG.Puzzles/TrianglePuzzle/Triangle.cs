namespace UHG.Puzzles.TrianglePuzzle
{
    public class Triangle
    {
        public Triangle(int sideA, int sideB, int sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public int SideA { get; }
        public int SideB { get; }
        public int SideC { get; }

        public virtual bool IsValid()
        {
            var allPositive = SideA > 0 && SideB > 0 && SideC > 0;
            if (!allPositive)
            {
                return false;
            }

            var isAccordingToTriangleTheory = (SideA + SideB > SideC) &&
                                              (SideA + SideC > SideB) &&
                                              (SideB + SideC > SideA);

            return isAccordingToTriangleTheory;


        }
    }
}