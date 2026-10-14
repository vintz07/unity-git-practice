using UnityEngine;

//public class pratice1 : MonoBehaviour
public class ClassExample : MonoBehaviour
{
    private void Start()
    {
        float result = Half(4); 
        Debug.Log(result);
    }
    float Half(float num)
    {
        return num / 2;
    }
        // Start is called once before the first execution of Update after the MonoBehaviour is created

        //void Start()
        //{
        //int k = 1;
        //while (k <= 10)
        //{
        //    if(k%2==0)
        //    {
        //        k++;
        //        continue;
        //    }
        //    Debug.Log(k);
        //    k++;
        //}


        //}


        // Update is called once per frame
        void Update()
    {
        
    }
}
