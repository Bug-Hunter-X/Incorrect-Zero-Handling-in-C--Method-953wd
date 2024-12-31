public class MyClass {
    public int MyMethod(int a, int b) {
        if (b == 0) {
            return 0; // Handle division by zero
        }
        if (a == 0) {
            return 0; // Handle zero numerator
        }
        return a / b;
    }
}