public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0 || b == 0) {
            return 0; // This is the problematic line
        }
        return a / b;
    }
}