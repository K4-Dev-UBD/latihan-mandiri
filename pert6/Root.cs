using System;

namespace pert6 {
  class Root {
    static void Main(string[] args) {
      array3DWithUserInp();
      jaggedArrayWithUserInp();
    }

    public static void array3DWithUserInp() {
      Console.WriteLine("====== Array 3D dengan Inputan ======\n");

      int value1 = 0, value2 = 0, value3 = 0;
      Console.Write("Masukkan jumlah halaman: ");
      value1 = int.Parse(Console.ReadLine());
      Console.Write("Masukkan jumlah baris: ");
      value2 = int.Parse(Console.ReadLine());
      Console.Write("Masukkan jumlah kolom: ");
      value3 = int.Parse(Console.ReadLine());

      Console.WriteLine("\n");

			int[,,] arr = new int[value1, value2, value3];

			for (int i = 0; i < value1; i++) {
				for (int j = 0; j < value2; j++) {
					for (int k = 0; k < value3; k++) {
						Console.Write($"Isikan nilai untuk\nHalaman {i + 1} Baris {j + 1} Kolom {k + 1}: ");
						arr[i, j, k] = int.Parse(Console.ReadLine());
					}
				}
			}

			Console.Write("==== Hasil ====");
			for (int i = 0; i < value1; i++) {
				Console.WriteLine();
				for (int j = 0; j < value2; j++) {
					Console.WriteLine();
					for (int k = 0; k < value3; k++) {
						Console.Write($"{arr[i, j, k]}\t");
					}
				}
				Console.WriteLine("\n");
			}

			Console.ReadKey(true);
    }

    public static void jaggedArrayWithUserInp() {
      Console.WriteLine("====== Jagged Array dengan Inputan ======\n");

      int value1 = 0, value2 = 0;
      Console.Write("Masukkan jumlah baris: ");
      value1 = int.Parse(Console.ReadLine());

      int[][] arr = new int[value1][];

      for (int i = 0; i < arr.Length; i++) {
        Console.Write($"Masukkan jumlah kolom untuk baris {i + 1}: ");
        value2 = int.Parse(Console.ReadLine());
        arr[i] = new int[value2];
        for (int j = 0; j < (arr[i]).Length; j++) {
          Console.Write($"Isikan nilai baris {i + 1} kolom {j + 1}: ");
          arr[i][j] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
      }

      Console.WriteLine("==== Hasil ====");
      for (int i = 0; i < arr.Length; i++) {
        Console.WriteLine();
        for (int j = 0; j < (arr[i]).Length; j++) {
          Console.Write($"{arr[i][j]}\t");
        }
        Console.WriteLine();
      }
      Console.ReadKey(true);
    }
  }
}
