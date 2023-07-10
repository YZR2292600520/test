using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public float maxSpeed = 10;
    public float minSpeed = 1;
    public Sprite hurt;
    private SpriteRenderer spre;
    public GameObject boom;
    public GameObject score;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.relativeVelocity.magnitude);
        if (collision.relativeVelocity.magnitude > maxSpeed) //À¿Õˆ
        {
            Dead();
        }
        else if (collision.relativeVelocity.magnitude > minSpeed) // ‹…À
        {
            spre.sprite = hurt;
        }
    }
    void Start()
    {
        spre = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Dead()
    {
        Destroy(gameObject);
        Instantiate(boom, transform.position, Quaternion.identity);
        GameObject score1 = Instantiate(score, transform.position + Vector3.up, Quaternion.identity);
        Destroy(score1, 1.5f);
    }
}
