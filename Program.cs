public class Kalkulator{
 public static double tambah(double a, double b){
  return a+b;
 }

 public static double kurang(double a, double b){
  return a-b;
 }

 public static double Kali(double a, double b){
  return a*b;
 }

 public static double bagi(double a, double b){
  return a/b;
 }

 public static void fungsiKalkulator(string operasi_matematika, double a, double b){
  switch(operasi_matematika){
   case "+":
   Console.WriteLine("Hasil Operasi = " + tambah(a, b));
   break;
   case "-":
   Console.WriteLine("Hasil Operasi = " + kurang(a, b));
   break ;
   case "*":
   Console.WriteLine("Hasil Operasi = " + Kali(a, b));
   break;
   case "/":
   Console.WriteLine("Hasil Operasi = " + bagi(a, b));
   break;
  }
 }

 public static void mainfunc(){
  Console.Write("Masukkan Angka Pertama: ");
  double angka1 = Convert.ToDouble(Console.ReadLine());
  Console.Write("Masukkan Operator [+], [-], [*], [/]: ");
  string operasi = Console.ReadLine();
  Console.Write("Masukkan Angka Kedua: ");
  double angka2 = Convert.ToDouble(Console.ReadLine());
  fungsiKalkulator(operasi, angka1, angka2);
 }

 public static void Main(String[] args){
  mainfunc();
 }
}