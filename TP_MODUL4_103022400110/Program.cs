using System;

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek dari class KodePos
        KodePos kode = new KodePos();

        Console.Write("Masukkan Kelurahan: "); // Output
        string kelurahan = Console.ReadLine(); // Input kelurahan

        int kodepos = kode.getKodePos(kelurahan); // Panggil method getKodePos

        Console.WriteLine("Kode Pos: " + kodepos); // Output kode pos

        DoorMachine pintu = new DoorMachine();

        // Membuat objek dari class DoorMachine
        pintu.BukaPintu(); // Panggil method BukaPintu
        pintu.KunciPintu(); // Panggil method KunciPintu
    }
}