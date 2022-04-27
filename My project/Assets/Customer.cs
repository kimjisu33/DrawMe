using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Rigidbody2D rigidbody;
    public Sprite[] sprite; //�̹���   0���     1����     2����
    public string[] comment; //��� �迭
    int satisfaction;   //������
    //��

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody=GetComponent<Rigidbody2D>();
        rigidbody.velocity = Vector2.up*15;
        satisfaction = -1;
        
    }
    private void Update()
    {
        if (transform.position.y > -2) rigidbody.velocity = Vector2.zero;

    }



    void MoveDown()
    {
        
        Destroy(gameObject);
    }

    public void Reaction(int satisfaction)
    {
        //1. �̹��� �ٲ�� / ��� �ٲ�� (�ð���)
        //2. �ݾ� �����ϱ�
        //3. ������ ������� (��ü ����)

        spriteRenderer.sprite = sprite[1];
        rigidbody.velocity = Vector2.down * 15;
        //������ ������� ��ü ���� �ǰ� �����!!!!!!!!!!!!!!!!!
        Invoke("MoveDown", 0.5f);

    }

   
}
