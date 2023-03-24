using System.Diagnostics;

int[] arr;
Console.WriteLine("Introduce número de elementos: ");
int n = Convert.ToInt32(Console.ReadLine());
// int n = 1000;
arr = new int[n];

for (int i = 0; i < n; i++) {
    arr[i] = 1;
}

Stopwatch crono = Stopwatch.StartNew();
for (int j = 0; j < n; j++) {
    for (int k = n - 1; k > 0; k--) {
        arr[k] = j + k;
    }
}
crono.Stop();
Console.WriteLine($"Para {n} elementos, set tarda: {crono.Elapsed}");