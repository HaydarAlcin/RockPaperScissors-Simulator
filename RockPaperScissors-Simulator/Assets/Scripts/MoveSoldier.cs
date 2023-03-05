using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MoveSoldier : MonoBehaviour
{
    public AudioClip[] sounds;

    public string rock, paper, scissors;
    public float speed;

    

    void Update()
    {
        Move();
    }

    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (this.gameObject.tag == paper)
        {
            if (collision.tag == rock)
            {
                gameObject.GetComponent<AudioSource>().clip = sounds[1];
                gameObject.GetComponent<AudioSource>().Play();
                collision.GetComponent<AudioSource>().Stop();
                collision.GetComponent<SpriteRenderer>().sprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;
                collision.tag = paper;
            }

        }

        else if (this.gameObject.tag == rock)
        {
            if (collision.tag == scissors)
            {
                gameObject.GetComponent<AudioSource>().clip = sounds[2];
                gameObject.GetComponent<AudioSource>().Play();
                collision.GetComponent<AudioSource>().Stop();
                collision.GetComponent<SpriteRenderer>().sprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;
                collision.tag = rock;

            }

        }

        else if (this.gameObject.tag == scissors)
        {
            if (collision.tag == paper)
            {
                gameObject.GetComponent<AudioSource>().clip = sounds[0];
                gameObject.GetComponent<AudioSource>().Play();
                collision.GetComponent<AudioSource>().Stop();
                collision.GetComponent<SpriteRenderer>().sprite = this.gameObject.GetComponent<SpriteRenderer>().sprite;
                collision.tag = scissors;

            }

        }
    }


    //Hareket Fonksiyonu
    public void Move()
    {
        if (this.gameObject.tag == paper)
        {
            if (GameObject.FindGameObjectsWithTag(rock).Length > 0)
            {
                //tag'e sahip olan tum nesneleri al
                GameObject[] paper = GameObject.FindGameObjectsWithTag(rock);

                //nesneleri uzakliklarina göre sýrala
                GameObject closestRock = paper.OrderBy(obj => Vector2.Distance(transform.position, obj.GetComponent<Transform>().position)).FirstOrDefault();


                //Targetta dogru sabit hareket etmek icin lerp yerine movetowards kullaniyoruz
                Vector2 newPosition = Vector2.MoveTowards(transform.position, closestRock.transform.position, speed * Time.deltaTime);
                // player nesnesini yeni pozisyona tasi
                transform.position = newPosition;
            }


        }

        else if (this.gameObject.tag == rock)
        {
            if (GameObject.FindGameObjectsWithTag(scissors).Length > 0)
            {
                //tag'e sahip olan tum nesneleri al
                GameObject[] rock = GameObject.FindGameObjectsWithTag(scissors);

                //nesneleri uzakliklarina göre sýrala
                GameObject closestScissors = rock.OrderBy(obj => Vector2.Distance(transform.position, obj.GetComponent<Transform>().position)).FirstOrDefault();


                //Targetta dogru sabit hareket etmek icin lerp yerine movetowards kullaniyoruz
                Vector2 newPosition = Vector2.MoveTowards(transform.position, closestScissors.transform.position, speed * Time.deltaTime);
                // player nesnesini yeni pozisyona tasi
                transform.position = newPosition;
            }


        }

        else if (this.gameObject.tag == scissors)
        {
            if (GameObject.FindGameObjectsWithTag(paper).Length > 0)
            {
                //tag'e sahip olan tum nesneleri al
                GameObject[] scissors = GameObject.FindGameObjectsWithTag(paper);

                //nesneleri uzakliklarina göre sýrala
                GameObject closestPaper = scissors.OrderBy(obj => Vector2.Distance(transform.position, obj.GetComponent<Transform>().position)).FirstOrDefault();


                //Targetta dogru sabit hareket etmek icin lerp yerine movetowards kullaniyoruz
                Vector2 newPosition = Vector2.MoveTowards(transform.position, closestPaper.transform.position, speed * Time.deltaTime);
                // player nesnesini yeni pozisyona tasi
                transform.position = newPosition;
            }


        }
    }
}
