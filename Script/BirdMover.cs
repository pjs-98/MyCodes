using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMover : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;
    public Transform desPos;
    public float speed;

    // Start is called before the first frame update

    //������ ��ġ�� startPos, desPos�� endPos�� position������ �ʱ�ȭ ��Ŵ.
    void Start()
    {
        transform.position = startPos.position;
        desPos = endPos;
    }

    // Update is called once per frame

    //���㰡 desPos�� �����ϸ� desPos�� ���� startPos�� �ʱ�ȭ �Ͽ� �� ���̸� �պ��ϰ� ����.

    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, desPos.position, Time.deltaTime * speed);

        if (Vector2.Distance(transform.position, desPos.position) <= 0.05f)
        {
            if (desPos == endPos) desPos = startPos;
            else desPos = endPos;
        }
    }

}
