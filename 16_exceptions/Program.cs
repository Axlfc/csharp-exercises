// Excepciones

Console.WriteLine($"1 entre 2: {DivisionSegura(1, 2)}");
try {
    Console.WriteLine($"1 entre 2: {DivisionSegura(1, 0)}");
} catch (Exception ex) {
    Console.WriteLine($"An exception has ocurred: {ex.Message}");
}

static double DivisionSegura(double a, double b) {
    if (b == 0) {
        throw new DivideByZeroException();
    }
    return a / b;
}