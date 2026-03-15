using System;

class Program
{
    static void Main(string[] args)
    {
        KodePos kode = new KodePos();

        Console.Write("Masukkan Kelurahan: ");
        string kelurahan = Console.ReadLine();

        int kodepos = kode.getKodePos(kelurahan);

        Console.WriteLine("Kode Pos: " + kodepos);
    }
}