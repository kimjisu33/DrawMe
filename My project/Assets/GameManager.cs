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
        //°´Ã¼ »ý¼º
        
        
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            obj=Instantiate(customers[0], spawnPoint.position, spawnPoint.rotation);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            obj.GetComponent<Customer>().Reaction(10);
        }
    }

}
