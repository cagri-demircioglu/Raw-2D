using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterHareket : MonoBehaviour
{

    private Rigidbody2D rb2;
    public float speed = 1;
    public int secim = 1;
    public bool ziplamaKontrol = false;
    void Start()
    {

        rb2 = GetComponent<Rigidbody2D>();
        // Bu komutla objemize eklediğimiz Rigidbody2D compenentini rb2'ye atıyoruz.

    }

    // Update is called once per frame
    void Update()
    {

        if (secim ==1)

        {
            if(ziplamaKontrol==true)
            {

            
        if(Input.GetKeyDown(KeyCode.W))
        // Burada "W" tuşuna her bastığımızda belirlediğimiz hız değeriyle tuşa bastığımız sürece  nesnenin hızı artacak.(Örneğin arabanın hızlanması gibi)

        {
            rb2.velocity = new Vector2(0, speed * 2);
        }
            }
            if (Input.GetKey(KeyCode.A))
        {
            rb2.AddForce(Vector2.left * speed);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rb2.AddForce(Vector2.right * speed);
        }
        if(Input.GetKey(KeyCode.S))
        {
            rb2.AddForce(Vector2.down * speed);
        }
        }
        if(secim ==2)
        {

            if(Input.GetKeyDown(KeyCode.W))
            {
                rb2.velocity = new Vector2(0, speed);
            }

            if(Input.GetKey(KeyCode.S))
            {
                rb2.velocity = new Vector2(0, -speed);
            }
            if(Input.GetKey(KeyCode.A))
            {
                rb2.velocity = new Vector2(-speed, 0);
            }
            if(Input.GetKey(KeyCode.D))
            {
                rb2.velocity = new Vector2(speed, 0);
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "zemin")
        {
            ziplamaKontrol = true;
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "zemin")
        {
            ziplamaKontrol = false;
        }
    }
}
