// Arrays

int[] array = new int[2];

int[] array2 = new int[] { 1, 2, 3, 4 };

int[] array3 = { 1, 2, 3 };


array[0] = 1;
array[1] = 2;

Console.Write("Array3 = ( ");
for (int i = 0; i < array3.Length; i++) {
    array3[i]++;
}


foreach (int elem in array3) {
    Console.Write(elem + " ");
}
Console.Write(")\n");

// 2D arrray declaration knowing the number of elements but without knowing elements
int size_x = 2;
int size_y = 10;
int[,] arr2D = new int[size_x, size_y];

for(int j = 0; j < size_x; j++) {
    for(int k = 0; k < size_y; k++) {
        arr2D[j, k] = j + k;
        Console.Write(arr2D[j, k] + "\t");
    }
    Console.WriteLine();
}



// (0, 0) -> arr2D[0, 0]