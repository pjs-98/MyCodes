using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainGenerator : MonoBehaviour
{


    public GameObject RainPrefab;
    float span = 1.0f;
    float delta = 0;


    // Update is called once per frame

    // RainPrefab�� x�� -6 ~ 7, y�� 60 ���̿��� ��� ������Ŵ.
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(RainPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 60, 0);
        }
    }
}