using UnityEngine;

public class MultiArray : MonoBehaviour
{
    void Start()
    {
        #region 2D_Array
        // 2D array : Every row has same length
        /*int[,] intArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

        for (int i = 0; i < intArray.GetLength(0); i++)
        {
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                Debug.Log($"{i}, {j} : {intArray[i, j]}");
            }
        }*/
        #endregion

        #region MultiArray
        // Jagged array : Row can have difference length
        int[][] multiArray = new int[3][];
        multiArray[0] = new int[2];
        multiArray[1] = new int[3];
        multiArray[2] = new int[4];

        multiArray[0][0] = 1;
        multiArray[0][1] = 2;

        multiArray[1][0] = 3;
        multiArray[1][1] = 4;
        multiArray[1][2] = 5;

        multiArray[2][0] = 6;
        multiArray[2][1] = 7;
        multiArray[2][2] = 8;
        multiArray[2][3] = 9;

        for (int i = 0;i < multiArray.Length; i++)
        {
            for (int j = 0; j < multiArray[i].Length; j++)
            {
                Debug.Log($"{i}, {j} : {multiArray[i][j]}");
            }
        }
        #endregion
    }
}
