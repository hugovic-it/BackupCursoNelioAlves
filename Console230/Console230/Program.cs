namespace Console230;

delegate double BinaryNumericOperation(double n1, double n2);
class Program {
    static void Main(string[] args) {
        BinaryNumericOperation op = CalculationService.Sum;
        double a = 10;
        double b = 12;
        double result = op(a, b);
        Console.WriteLine(result);    
    }
}