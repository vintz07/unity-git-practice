using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    float health = 100.0f;

    private void TakeDamge(int value)
    {
        health -= value;
        if (health <= 0)
        {
            Die();
        }

        Debug.Log("Player Health:" + health);
    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        TakeDamge(20);
        Destroy(coll.gameObject);
    }



    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
