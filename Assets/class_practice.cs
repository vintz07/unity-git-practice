using UnityEngine;

public class class_practice : MonoBehaviour
{
    void Start()
    {
        Human Alice = new Human("alice", 23, 160);


        //Debug.Log(Alice.name);
        //Debug.Log(Alice.age);
        //Debug.Log(Alice.height);

        //Human John = new Human();

        //Debug.Log(John.name);
        //Debug.Log(John.age);
        //Debug.Log(John.height);
    }

    // Human 클래스를 Start() 바깥으로 이동
   

    void Update()
    {
    }
}

 class Human
{
    string name;
    float height;
    int age;

    public Human()
    {
    }

    public Human(string _name, int _age, float _height)
    {
     name = _name;
     age = _age;
     height = _height;
    }
    
    public int Age
    { 
        get 
        { 
            return age; 
        }
        set 
        { 
            Debug.Log(value); 
            age = value; 
        }
    }

}