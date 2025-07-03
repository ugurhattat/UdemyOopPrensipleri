using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Bmw : Araba, IAlman
{
    //bu bir constructor yani yapici method'tur
    //bu bizim ilk yazsakta yazmasakta default ctor yapici method
    public Bmw()
    {

    }

    //ctor tap tap constructor yazmanin kisa yolu
    public Bmw(string model)
    {
            Model = model;
    }

    public Bmw(string model, string marka)
    {
        Model = model;
        Marka = marka;
    }

    public Bmw(string model, string marka, float hizi, byte kapiSayisi, bool sifirMi, bool ucuyorMu, decimal fiyati)
    {
        Model = model;
        Marka = marka;
        KapiSayisi = kapiSayisi;
        SifirMi = sifirMi;
        UcuyorMu = ucuyorMu;
        Fiyati = fiyati;

        SatisYap1();
    }
    public bool UcuyorMu {  get; set; }
    public bool AlmanMi { get; set; }

    public void AlmanSatisYap()
    {
        if (AlmanMi)
        {
            ToplamFiyati -= 4000m;
        }
    }

    public override void SatisYap1()
    {
        ToplamFiyati = Fiyati;

        if (SifirMi)
        {
            ToplamFiyati += 4000m;
        }

        if (UcuyorMu)
        {
            ToplamFiyati += 6000m;
        }
    }

    public override void SatisYap2()
    {
        throw new System.NotImplementedException();
    }
}
