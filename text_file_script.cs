using System;
using System.IO;

class AdminFilter {
    static void Main() {
        foreach (string line in File.ReadLines("users.txt")) {
            if (line.Contains("admin")) {
                Console.WriteLine(line);
            }
        }
    }
}
