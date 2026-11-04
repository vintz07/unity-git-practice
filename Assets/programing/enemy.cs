using UnityEngine;

public class enemy : MonoBehaviour
{

    float health = 50.0f;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void TakeDamge(int value)
    {
        health -= value;
        if ( health <= 0 )
        {
            Die();
        }
    }

    public float GetHealth()
    {
        return health;
    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            TakeDamge(10);
            coll.gameObject.SetActive(false);
        }
    }
     public virtual void Move()
    {

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
