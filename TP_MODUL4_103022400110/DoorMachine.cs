using System;

public class DoorMachine
{
    private string state = "Terkunci"; // Buat var state untuk menyimpan status pintu

    public void BukaPintu() // Method untuk membuka pintu
    {
        if (state == "Terkunci")
        {
            state = "Terbuka"; // Ubah status pintu menjadi terbuka
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    public void KunciPintu() // Method untuk mengunci pintu
    {
        if (state == "Terbuka")
        {
            state = "Terkunci"; // Ubah status pintu menjadi terkunci
            Console.WriteLine("Pintu terkunci");
        }
    }
}