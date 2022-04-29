using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Rigidbody2D rigidbody;
    public Sprite[] sprite; //이미지   0평소     1좋음     2나쁨
    public string[] comment; //대사 배열
    //int satisfaction;   //만족도
    //모델


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody=GetComponent<Rigidbody2D>();
        rigidbody.velocity = Vector2.up*15;
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
        transform.position=new Vector2(transform.position.x, transform.position.y-1);
        rigidbody.velocity = Vector2.down * 15;
        
    }

    public void Reaction(int satisfaction)
    {
        //1. 이미지 바뀌기 / 대사 바뀌기 (시간차)
        //2. 금액 지불하기
        //3. 밑으로 사라지기 (객체 삭제)

        if (satisfaction > 50)
        {
            spriteRenderer.sprite = sprite[1]; //만족
            //만족스러운 금액 지불
        }
        else
        {
            spriteRenderer.sprite = sprite[2]; //불만족
            //불만족스러운 금액 지불
        } 
        Invoke("MoveDown", 1f);
        Destroy(this.gameObject, 1.5f);
    }

    public string order()
    {
        return comment[0];
    }
}
