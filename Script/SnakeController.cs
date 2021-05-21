using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeController : MonoBehaviour
{
    public float maxSpeed;
    public float jumpPower;

    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //������ ����.
        if (Input.GetButtonDown("Jump") && this.rigid.velocity.y == 0)
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);

        //�¿�� �̵��� ����.
        if (Input.GetButtonUp("Horizontal"))
        {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }

        // �¿�� �̵� �� �̹��� ������ ����.
        if (Input.GetButtonDown("Horizontal"))
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;
    }

    void FixedUpdate()
    {
        //ĳ������ �ӵ��� ������.
        float h = Input.GetAxisRaw("Horizontal");

        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (rigid.velocity.x > maxSpeed)
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        else if (rigid.velocity.x < maxSpeed * (-1))
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
    }


    //��ü�� Circle�� ������ ClearScene�� ȣ����.

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.name == "Circle")
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
