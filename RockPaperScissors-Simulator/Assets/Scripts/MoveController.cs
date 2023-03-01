using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public string rock, paper, scissors;

    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // tag'e sahip olan t�m nesneleri al
        GameObject[] paper = GameObject.FindGameObjectsWithTag(rock);

        // nesneleri uzakl�klar�na g�re s�rala
        GameObject closest = paper.OrderBy(obj => Vector2.Distance(transform.position, obj.GetComponent<Transform>().position)).FirstOrDefault();

        Vector2 closestPosi = closest.transform.position;

        Vector2 newPosition = Vector2.Lerp(transform.position, closestPosi, speed * Time.deltaTime);

        // player nesnesini yeni pozisyona ta��
        transform.position = newPosition;


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "rock")
        {
            Destroy(collision.gameObject);
        }
    }
}
