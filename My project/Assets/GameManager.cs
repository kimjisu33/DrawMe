using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] customers;
    public Transform spawnPoint;
    private GameObject obj;

    private void Start()
    {
        //객체 생성
        
        
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow)) //이제 위쪽 화살표 말고 게임 시작 | 앞 고객 완료 되면 객체 생성
        {

            obj=Instantiate(customers[0], spawnPoint.position, spawnPoint.rotation);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) //아래쪽 화살표 말고 만족도가 -1이 아니면 리액션 후 객체 삭제
        {
            obj.GetComponent<Customer>().Reaction(10);
        }
    }

}
