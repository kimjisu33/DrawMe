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
        //��ü ����
        
        
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow)) //���� ���� ȭ��ǥ ���� ���� ���� | �� �� �Ϸ� �Ǹ� ��ü ����
        {

            obj=Instantiate(customers[0], spawnPoint.position, spawnPoint.rotation);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) //�Ʒ��� ȭ��ǥ ���� �������� -1�� �ƴϸ� ���׼� �� ��ü ����
        {
            obj.GetComponent<Customer>().Reaction(10);
        }
    }

}
