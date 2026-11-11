
using UnityEngine;

public class InheritanceExample : MonoBehaviour
{
    void Start()
    {
        Adult john = new Adult("john", 28, 173);
        Baby lisa = new Baby("lisa", 3, 95);

        Debug.Log(john.Age);
        lisa.Sleep();

        // base 키워드

        Adult maria = new Adult("maria", 10, 12);

        maria.Age = 10;
        maria.SetBaseAge(2);

        Debug.Log(maria.Age);
        Debug.Log(maria.GetBaseAge());

        //Human Paul = new Human("Paul", 3, 90); //실패사례
        //Baby baby = Paul as Baby;

        //if (baby==null)
        //{
        //    Debug.Log("형변환 실패");
        //}
        //else 
        //{
        //    Debug.Log("형변환 성공");
        //}

        Human Alexis = new Adult("alexis", 23, 155); //성공사례
        Adult adult_alexis = Alexis as Adult; 

        if (adult_alexis == null)
        {
            Debug.Log("형변환 실패");
        }
        else
        {
            Debug.Log("형변환 성공");
        }

        //Human jason = maria;
        //Debug.Log(jason.GetAge());

        //Human Bob = new Human("Bob", 26, 165.5f);
        //Adult tmpA = (Adult)Bob;

        //Human jason = new Adult("jason", 32, 172);//Adult 타입
        //Adult adult = (Adult)jason;
    }
}

class Human
{
    string name;
    protected int age;
    float height;

    protected string address;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public float Height
    {
        get { return height; }
        set { height = value; }
    }

    public int GetAge()
    {
        return age;
    }

    public void SetAge(int _age)
    {
        age = _age;
    }

    public Human()
    {
    }

    public Human(string _name, int _age, float _height)
    {
        name = _name;
        age = _age;
        height = _height;
    }

    public void Eat()
    {
        Debug.Log("eat");
    }

    public virtual void Walk()
    {
        Debug.Log("walk");
    }

    public virtual void Sleep()
    {
        Debug.Log("sleep");
    }
}


class Adult : Human
{
    public Adult(string _name, int _age, float _height)
        : base(_name, _age, _height) { Age = _age; }

    public new int Age;

    public void SetBaseAge(int age)
    {
        base.age = age;
    }

    public int GetBaseAge()
    {
        return base.age;
    }
}

class Baby : Human
{
    public Baby(string _name, int _age, float _height)
        : base(_name, _age, _height) { }
}

