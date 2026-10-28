using UnityEngine;

public class enemy : MonoBehaviour
{

    float health = 50.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void TakeDamge(int value)
    {
        health -= value;
    }

    public float GetHealth()
    {
        return health;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        TakeDamge(10);
        Debug.Log("Health:" + health);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
