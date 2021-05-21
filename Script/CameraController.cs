using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //���۰� ���ÿ� "Snake" ������Ʈ�� ã��.
        this.player = GameObject.Find("Snake");
    }

    // Update is called once per frame
    void Update()
    {
        //������Ʈ�� x, y, z���� ���� ī�޶��� �����ǵ� ���� �����.
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(
            transform.position.x, playerPos.y, transform.position.z);
    }
}

