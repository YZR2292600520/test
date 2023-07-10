using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pig : MonoBehaviour
{
    public float maxSpeed = 10;
    public float minSpeed = 4;
    private SpriteRenderer spe;
    public Sprite hurt;
    public GameObject boom;
    public GameObject score;
    //public bool isPig = false;
    void Start()
    {
        spe = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.relativeVelocity.magnitude);
        if (collision.relativeVelocity.magnitude>maxSpeed) //À¿Õˆ
        {
            Dead();
        }
        else if(collision.relativeVelocity.magnitude>minSpeed) // ‹…À
        {
            spe.sprite = hurt;
        }
    }

    void Dead()
    {

        GameManager.Instance.pigs.Remove(this);

        Destroy(gameObject);
        Instantiate(boom, transform.position, Quaternion.identity);
        GameObject score1 = Instantiate(score, transform.position + Vector3.up, Quaternion.identity);
        Destroy(score1, 1.5f);
    }
}
