Sample s = new Sample();
Sample.M1();
s.M2(123);

class Sample {
    public static void M1() {
        Console.WriteLine("M1 Method");
    }
    public  void M2() {
        M1();
        Console.WriteLine("M2 Method");
    }
    public void M2(int i) {
        Console.WriteLine(i);
        M2();
    }
}

Sample.M1();
class Sample{
    public Sample(){
        Console.Write("sample class");
    }
    public static void M1() {
        Console.Write("M1 object");
    }
}


int num = 1, z = 5
 Console.WriteLine(++num + z++ + " " + ++z)


int[] a = new int[] {10,20};
Swap(a);
void Swap(int [] a) {
    int temp a[0];
    a[0] = a[1];
    a[1] = temp
}
Console.Write("a[0] = {0}, a[1] = {1}", a[0], a[1])

int[] a = new int[] {10,20};
Swap(a[0], a[1]);
void Swap(int a0, int a1) {
    int temp a0;
    a0 = a1;
    a[1] = temp
}
Console.Write("a[0] = {0}, a[1] = {1}", a[0], a[1])




init num  = 1;
funcv(num);

Console.Write(num + ",");
funcr(ref num);
Console.Write(num + ",);

void funcr(ref num) {
    num = num + 10;
    Console.Write(num + ",);
}
void funcv(ref int num) {
    num = num + 10;
    Console.Write(num + ",);
}