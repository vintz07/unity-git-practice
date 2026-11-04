using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f; //public 외부 공용, private 비공개
    public GameObject BulletPrefab;
    public float BulletSpeed = 100f;
    int[] scores = new int[5];



    void Start()
    {
        for (int i = 1; i < scores.Length; i++) 
            scores[i-1] = (i+1)*10;

        Debug.Log(scores[0]); 
        Debug.Log(scores[1]); 
        Debug.Log(scores[2]); 
        Debug.Log(scores[3]); 
        Debug.Log(scores[4]);
        //bool a = true;
        //bool b = false;
        //gameObject.SetActive(a || b);
        //Vector2 newPos = transform.position;
        //newPos.x = newPos.x + 5;
        //transform.position = newPos;

        //transform.position = Vector3.one; //(1, 1, 1)



    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x, y, 0);
        transform.position += direction.normalized * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space)) //y축 수정해서 3발
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject Bullet = Instantiate(BulletPrefab);
                Vector3 bulletPos = transform.position;

                bulletPos.y += 0.3f * i;
                Bullet.transform.position = bulletPos;
                Bullet.GetComponent<Rigidbody2D>().
                                     AddForce(Vector2.up * BulletSpeed);
            }
        }

        //if (Input.GetKeyDown(KeyCode.Space)) //  뭉쳐서 3발
        //{
        //    GameObject Bullet1 = Instantiate(BulletPrefab); //Instantiate==실체화명령어
        //    Bullet1.transform.position = transform.position; //transform.position==플레이어위치, Bullet.transform.position==총알위치
        //    Bullet1.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed);

        //    GameObject Bullet2 = Instantiate(BulletPrefab); //Instantiate==실체화명령어
        //    Bullet2.transform.position = transform.position; //transform.position==플레이어위치, Bullet.transform.position==총알위치
        //    Bullet2.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed);

        //    GameObject Bullet3 = Instantiate(BulletPrefab); //Instantiate==실체화명령어
        //    Bullet3.transform.position = transform.position; //transform.position==플레이어위치, Bullet.transform.position==총알위치
        //    Bullet3.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed);
        //}


        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    this.transform.Translate(0, speed, 0);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    this.transform.Translate(0, -speed, 0);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    this.transform.Translate(speed, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    this.transform.Translate(-speed, 0, 0);
        //}
    }
}
