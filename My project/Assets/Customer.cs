using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Rigidbody2D rigidbody;
    public Sprite[] sprite; 
    public string[] comment;
    
    private string now_comment;
    //int satisfaction;



    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = Vector2.up * 15;
        //satisfaction = -1;


    }
    private void Update()
    {
        if (transform.position.y > -2)
        {
            rigidbody.velocity = Vector2.zero;
        }

    }



    void MoveDown()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - 1);
        rigidbody.velocity = Vector2.down * 15;

    }

    public void Reaction(int satisfaction)
    {
        //1. �̹��� �ٲ�� / ��� �ٲ�� (�ð���)
        //2. �ݾ� �����ϱ�
        //3. ������ ������� (��ü ����)

        if (satisfaction > 50)
        {
            spriteRenderer.sprite = sprite[1];  //����
            now_comment = comment[1];
            //���������� �ݾ� ����
        }
        else
        {
            spriteRenderer.sprite = sprite[2]; //�Ҹ���
            now_comment = comment[2];
            //�Ҹ��������� �ݾ� ����
        }
        Invoke("MoveDown", 1f);
        Destroy(this.gameObject, 1.5f);
    }


    public string getNowComment()
    {   
        return now_comment;
    }
}