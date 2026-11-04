using UnityEngine;

public class VariableExample : MonoBehaviour
{
    int a;                  //초기화 문장 in a = 1
    void Start()
    {
        a = 1;              //최초 한번 start() 메소드 실행= 초기화
        Debug.Log(a);
        //debug.Log("Hellow World");
    }

}
