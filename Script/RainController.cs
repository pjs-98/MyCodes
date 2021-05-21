using System.Collections;
using UnityEngine;

public class RainController : MonoBehaviour
{


    GameObject Snake;

    // Start is called before the first frame update
    void Start()
    {
        this.Snake = GameObject.Find("Snake");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.05f, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //�浹�� ����

        Vector2 p1 = transform.position;
        Vector2 p2 = this.Snake.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        //�浹�� �Ͼ�� ��ü�� ���� �� GameDirector�� DecreaseHp�� �˸�.

        if (d < r1 + r2)
        {
            Destroy(gameObject);

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
        }
    }
}