using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arsaKontrol : MonoBehaviour
{
    public bool[] satinAlinanArsalar;
    public bool satinAlmaKontrol = false;
    int arsaSayisi;
    public int arsaEtiketi = -1;
    public int arsaKontrolEtiketi = -1;
    // Start is called before the first frame update
    void Start()
    {
        arsaSayisi = satinAlinanArsalar.Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("arsaKontrol"))
        {
            arsaKontrolEtiketi = int.Parse(col.gameObject.tag);
            satinAlmaKontrol = true;
        }

        if (col.gameObject.layer == LayerMask.NameToLayer("satinAlinabilirArsa"))
        {
            arsaEtiketi = int.Parse(col.gameObject.tag);
            //karakterArsaKontrol.satinAlinanArsalar[i] = true;
            Debug.Log(arsaEtiketi.ToString());
        }

        for (int i = 0; i > arsaSayisi; i++)
        {
            
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("arsaKontrol"))
        {
            arsaKontrolEtiketi = -1;
            satinAlmaKontrol = false;
        }

        if (col.gameObject.layer == LayerMask.NameToLayer("satinAlinabilirArsa"))
        {
            arsaEtiketi = -1;
            //karakterArsaKontrol.satinAlinanArsalar[i] = true;
            Debug.Log(arsaEtiketi.ToString());
        }
    }


}
