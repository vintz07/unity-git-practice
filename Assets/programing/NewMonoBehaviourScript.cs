using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] vector = new int[100];
        for (int i = 0; i < vector.Length; i++) vector[i] = i;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
