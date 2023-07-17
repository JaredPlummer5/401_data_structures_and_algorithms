namespace CodeChallenges 
{
    public class CodeChallenge4
    {
        public static int GetNthNumberInFibonacciSequence(int nthNumberInSequence)
        {
            int result = 0;

            return result;
        }

        public static int[] RowSums(int[][] matrix)
        {
            int[] rowSums = new int[matrix.Length];
      for(int i = 0; i < rowSums.Length; i++)
      {
        int sum = 0;
        for(int j = 0; j < matrix[i].Length; j++)
        {
          sum += matrix[i][j];

        }
          rowSums[i] = sum;

      }
            return rowSums;
        }

    }
}