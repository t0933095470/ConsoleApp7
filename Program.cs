//Jagged array
//Declare a jagged array having 4 rows

int[][] jagged = new int[4][];

jagged[0] = new int[2];         // row 0 has 2 columns
jagged[1] = new int[3];         // row 1 has 3 columns
jagged[2] = new int[4];         // row 2 has 4 columns
jagged[3] = new int[5];         // row 3 has 4 columns

// Initialize value on the jagged array index (a)

jagged[0][0] = 4;       //store value in jagged array of row 0 and column 0
jagged[0][1] = 5;       //store value in jagged array of row 0 and column 1

// Initialize value on the jagged array index (b)

jagged[1] = new int[] { 12, 24, 35 };
jagged[2] = new int[] { 10, 76, 5, 90 };



// Initialize value on the jagged array index (c)

int[][] jagged_2 =
{
    new int[] {12, 24},
    new int[] {6, 7, 8},
    new int[] {9, 10, 11},
    new int[] {12, 13, 14, 15}
};

// Display each value in a jagged array index
// Loop over each index of jagged array 

for (int i = 0; i < jagged_2.Length; i++)
{
    for (int j = 0; j < jagged_2[i].Length; j++)
    {
        Console.WriteLine(jagged_2[i][j]);  
    }
    Console.WriteLine();
}