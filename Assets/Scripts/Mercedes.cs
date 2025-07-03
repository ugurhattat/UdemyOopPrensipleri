using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercedes : Araba, IAlman
{
    public bool YuzuyorMu { get; set; }
    public bool AlmanMi { get; set; }

    public void AlmanSatisYap()
    {
        if (AlmanMi)
        {
            ToplamFiyati -= 3000m;
        }
    }

    public override void SatisYap1()
    {
        ToplamFiyati = Fiyati;

        if (SifirMi)
        {
            ToplamFiyati += 5000m;
        }

        if (YuzuyorMu)
        {
            ToplamFiyati += 6000m;
        }
    }

    public override void SatisYap2()
    {
        throw new System.NotImplementedException();
    }
}
