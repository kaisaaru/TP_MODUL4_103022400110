using System;
using System.Collections.Generic;

public class KodePos
{
    private Dictionary<string, int> kodePos = new Dictionary<string, int>()
    {
        {"Batununggal",40266},
        {"Kujangsari",40287},
        {"Mengger",40267},
        {"Wates",40256},
        {"Cijaura",40287},
        {"Jatisari",40286},
        {"Margasari",40286},
        {"Sekejati",40286},
        {"Kebonwaru",40272},
        {"Maleer",40274}
    };

    public int getKodePos(string kelurahan)
    {
        return kodePos[kelurahan];
    }
}