using UnityEngine;

public class Conditinalstatement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        for (int i = 1; i < 6; i++) 
        { 
            Debug.Log (i);
        }
        //int a = 1; //스위치문
        //switch (a<5)
        //{
        //    case true:
        //        Debug.Log(a);
        //        break;
        //    case false:
        //        Debug.Log("a가 5보다 큽니다.");
        //        break;
        //    default:
        //        break;
        //}
        
        //int a = 8;  //if 조건문
        //if (a <= 5)
        //{
        //    Debug.Log(a);
        //}
        //else if (a < 10)
        //{
        //    Debug.Log("a가 5보다 크고 10보다 작습니다.");
        //}
        //else 
        //{
        //    Debug.Log("a가 10보다 크거나 같습니다.");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
