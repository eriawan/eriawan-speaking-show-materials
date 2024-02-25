namespace CollectionInitializers
{
    public class CollectionExpressions
    {
        // Create an array:
        int[] a = [1, 2, 3, 4, 5, 6, 7, 8];

        // Create a list:
        List<string> b = ["one", "two", "three"];

        // Create a jagged 2D array:
        int[][] twoD = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];


        int[][] CreateJagged2DArray()
        {
            // Create a jagged 2D array from variables:
            int[] row0 = [1, 2, 3];
            int[] row1 = [4, 5, 6];
            int[] row2 = [7, 8, 9];
            int[][] twoDFromVariables = [row0, row1, row2];
            return twoDFromVariables;
        }
    }
}
