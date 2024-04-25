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
    int standartCamGenisligi = 60, dusulecekYukseklik = 85, dusulecekAraBosluk = 5, dusulecekDikmePayi = 23;
    void Start()
    {

    }

    void Update()
    {

    }

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
            StartCoroutine(uyariGecikmesi());
        }
        else
        {

            yuk = int.Parse(girilenYukseklik) - dusulecekYukseklik;
            ad = int.Parse(girilenAdet);
            int toplamCam = int.Parse(girilenGenislik) / int.Parse(girilenAdet);
            //Hesaplama Devam




        }

        Debug.Log(girilenGenislik);

    }

}
