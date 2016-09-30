using System;
using Cooking.Models;

namespace RefactoringIfStatements
{
    public class StartUpRefactoringIfStatements
    {
        private const int MinXPosition = 0;
        private const int MaxXPosition = int.MaxValue;
        private const int MinYPosition = 0;
        private const int MaxYPosition = int.MaxValue;
        
        public static void Main(string[] args)
        {
            var potato = new Potato();
            var newChef = new Chef();

            if (potato == null)
            {
                throw new ArgumentException("Potato cannot be null");
            }
            else if (!potato.IsRotten)
            {
                newChef.Cook();
            }

            int positionX = 3;
            int positionY = 5;

            if (IsInRange(positionX, positionY) && CellIsNotVisited(positionX, positionY))
            {
                VisitCell(positionX, positionY);
            }
        }
        
        private static bool IsInRange(int positionX, int positionY)
        {
            if (positionX < MinXPosition || MaxXPosition < positionX)
            {
                return false;
            }
            else if (positionY < MinYPosition || MaxYPosition < positionY)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool CellIsNotVisited(int positionX, int positionY)
        {
            // logic
            return true;
        }

        private static bool VisitCell(int positionX, int positionY)
        {
            // logic
            return true;
        }
    }
}