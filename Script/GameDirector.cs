using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{

    GameObject hpGage;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGage = GameObject.Find("hpGage");
    }

    // DecreaseHP�� ȣ��Ǹ� fillAmount ���� 0.1�� ���ҽ�Ű�� 0�� �Ǹ� StartScene�� ȣ����.
    public void DecreaseHp()
    {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.1f;

        if (this.hpGage.GetComponent<Image>().fillAmount == 0f)
        {
            SceneManager.LoadScene("StratScene");
        }
    }

    //creaseHP�� ȣ��Ǹ� fillAmount�� 0.3 ������.

    public void CreaseHp()
    {
        this.hpGage.GetComponent<Image>().fillAmount += 0.3f;
    }
}
