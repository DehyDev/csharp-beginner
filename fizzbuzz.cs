Using System;

class MainClass {
  public static void Main (string[] args) {
    for (int i = 1; i <= 100; i++) {
      if (i % 15 == 0) {
        Console.WriteLine("GopnikAward");
      }
      else if (i % 3 == 0) {
        Console.WriteLine("Gopnik");
      }
      else if (i % 5 == 0) {
        Console.WriteLine("Award");
      }
      else {
        Console.WriteLine(i);
      }
    }
  }
}
