using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class generalScript : MonoBehaviour
{

    public Text genislik, camAdedi, yukseklik;
    public TextMeshProUGUI sonucYazisi, uyari;
    private int dusulecekYukseklik = 85, dusulecekAraBosluk = 5, dusulecekDikmePayi = 23;
    void Start()
    {}

    void Update()
    {}

    public void Hesapla()
    {

        IEnumerator uyariGecikmesi()
        {
            yield return new WaitForSeconds(3);
            uyari.text = "";
        }
        int gen, ad, yuk;
        float m2;
        string girilenGenislik = genislik.text.ToString();
        string girilenAdet = camAdedi.text.ToString();
        string girilenYukseklik = yukseklik.text.ToString();

        if (girilenGenislik == "" || girilenYukseklik == "" || girilenAdet == "")
        {
            uyari.text = "Genişlik, Yükseklik ve Adet\nalanlarını doldurunuz!";
            sonucYazisi.text = "";
            StartCoroutine(uyariGecikmesi());
        }
        else
        {

            yuk = int.Parse(girilenYukseklik) - dusulecekYukseklik;
            ad = int.Parse(girilenAdet);
            gen = int.Parse(girilenGenislik);
            gen = (gen / ad) - (2 * dusulecekDikmePayi) - (dusulecekAraBosluk * (ad - 1));

            m2 = (gen * yuk * ad) / 1000000f;

            sonucYazisi.text = gen + "mm x " + yuk + "mm  -> " + ad + " Adet\nToplam " + m2 + "m²";
        }
    }

}
