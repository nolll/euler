﻿using ConsoleApp.Tools;

namespace ConsoleApp.Problems
{
    public class Problem028 : Problem
    {
        public override int Id => 28;
        public override string Name => "Number spiral diagonals";

        public override PuzzleResult Run()
        {
            var result = Run(1001);

            return new PuzzleResult(result, 669_171_001);
        }

        public int Run(int size)
        {
            var matrix = BuildMatrix(size);
            return CalculateDiagonalSum(matrix);
        }

        private int CalculateDiagonalSum(Matrix<int> matrix)
        {
            var sum = 0;

            matrix.MoveTo(0, 0);
            while (true)
            {
                sum += matrix.ReadValue();
                if (matrix.TryMoveRight())
                    matrix.MoveDown();
                else
                    break;
            }

            matrix.MoveTo(matrix.Width - 1, 0);
            while (true)
            {
                sum += matrix.ReadValue();
                if (matrix.TryMoveLeft())
                    matrix.MoveDown();
                else
                    break;
            }

            sum -= 1;

            return sum;
        }

        private Matrix<int> BuildMatrix(int size)
        {
            var i = 1;
            var matrix = new Matrix<int>();
            matrix.WriteValue(i);
            matrix.TurnTo(MatrixDirection.Right);
            matrix.MoveForward();
            i++;
            matrix.WriteValue(i);
            i++;
            var max = size * size;

            while (i <= max)
            {
                matrix.TurnRight();
                matrix.MoveForward();
                if(matrix.ReadValue() > 0)
                {
                    matrix.MoveBackward();
                    matrix.TurnLeft();
                    matrix.MoveForward();
                }

                matrix.WriteValue(i);

                i++;
            }

            return matrix;
        }
    }
}