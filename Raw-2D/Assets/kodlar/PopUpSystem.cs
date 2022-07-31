using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PopUpSystem : MonoBehaviour
{
    public GameObject popUpBox;
    public GameObject InsaBox;
    public Animator animator;
    public TMP_Text popUpText;
    public GameObject arsa1;
    private arsa1Kontrol arsaKontrolu;
    private arsaKontrol karakterArsaKontrol;
    public GameObject karakter;
    int arsaEtiketGet;
    int arsaSatinAlmaEtiketGet;
    public GameObject[] satinAlinanlar;
    //public GameObject satinAlinan1;

    void Start()
    {
        arsaKontrolu = arsa1.GetComponent<arsa1Kontrol>();
        karakterArsaKontrol = karakter.GetComponent<arsaKontrol>();
        
        //arsaSayisi = karakterArsaKontrol.satinAlinanArsalar.Length;
        //Debug.Log(arsaSayisi);
    }

    private void FixedUpdate()
    {
        arsaEtiketGet = karakterArsaKontrol.arsaEtiketi;
        arsaSatinAlmaEtiketGet = karakterArsaKontrol.arsaKontrolEtiketi;
        Debug.Log(arsaEtiketGet);
        PopUp();
        InsaEtme();

    }
    public void PopUp()
    {

        if(arsaKontrolu.arsalarSatinAlmaKontroller[arsaSatinAlmaEtiketGet] == false && karakterArsaKontrol.satinAlmaKontrol == true && karakterArsaKontrol.satinAlinanArsalar[arsaEtiketGet]==false)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                popUpBox.SetActive(true);

            }

        }
    }

    public void InsaEtme()
    {
        if(arsaKontrolu.arsalarSatinAlmaKontroller[arsaSatinAlmaEtiketGet] == true && karakterArsaKontrol.satinAlmaKontrol == true && karakterArsaKontrol.satinAlinanArsalar[arsaEtiketGet] == true)
        {
            if(Input.GetKeyDown(KeyCode.B))
            {
                InsaBox.SetActive(true);
            }
        }
    }

    public void InsaOnay()
    {
        satinAlinanlar[arsaSatinAlmaEtiketGet].SetActive(true);
        //satinAlinan1.SetActive(true);
        InsaBox.SetActive(false);

    }

    public void arsaSatinAlindi()
    {

        karakterArsaKontrol.satinAlinanArsalar[arsaEtiketGet] = true;
        arsaKontrolu.arsalarSatinAlmaKontroller[arsaSatinAlmaEtiketGet] = true;
        //arsaKontrolu.arsa1SatinAlmaKontrol = true;
        popUpBox.SetActive(false);
        

    }
    public void satinAlmaIptal()
    {
        popUpBox.SetActive(false);
    }
    public void InsaIptal()
    {
        InsaBox.SetActive(false);
    }



}
