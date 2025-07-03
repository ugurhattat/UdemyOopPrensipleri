using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public bool SifirMi { get; set; }
    public float Hizi { get; set; }
    public byte KapiSayisi { get; set; }
    public decimal Fiyati { get; set; }
    public decimal ToplamFiyati { get; protected set; }

    public virtual void SatisYap1()
    {
        ToplamFiyati = Fiyati;

        if (SifirMi) //true
        {
            ToplamFiyati += 5000m;
        }
    }

    public abstract void SatisYap2();
}
