using System;
using System.Collections.Generic;
using System.Linq;

namespace UHG.Puzzles.TrianglePuzzle
{
    public class TriangleEvaluator
    {
        private readonly IEnumerable<ITriangleCriteria> _triangleCriterias;

        //
        // This is constructor injected, so that the evaluator just uses what it has been given.
        // If there was a new triangle criteria, it's just a matter of creating it implementing "ITriangleCriteria",
        // and we should be able to inject them via a DI resolver (i.e. autofac, ninject) or from reflection
        //
        public TriangleEvaluator(IEnumerable<ITriangleCriteria> triangleCriterias )
        {
            if (triangleCriterias == null)
            {
                throw new NullReferenceException("No triangle criterias defined");
            }

            _triangleCriterias = triangleCriterias;
        }

        public virtual TriangleType GetTriangleType(int sideA, int sideB, int sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);

            var triangleCriteria = _triangleCriterias.FirstOrDefault(criteria => criteria.IsValid(triangle));

            return triangleCriteria == null ? TriangleType.Error : triangleCriteria.TriangleType;
        }

    }
}