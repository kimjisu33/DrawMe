using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] customers;
    public Transform spawnPoint;
    private GameObject obj;

    public Text orderText;
    public Image textBox;

    private void Start()
    {

    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow)) //���� ���� ȭ��ǥ ���� ���� ���� | �� �� �Ϸ� �Ǹ� ��ü ����
        {
            //customer �����̱� �ֱ�
            obj = Instantiate(customers[0], spawnPoint.position, spawnPoint.rotation);
            orderText.text = obj.GetComponent<Customer>().comment[0];
            textBox.transform.position = new Vector2(textBox.transform.position.x, textBox.transform.position.y + 1000);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) //�Ʒ��� ȭ��ǥ ���� �������� -1�� �ƴϸ� ���׼� �� ��ü ����
        {
            obj.GetComponent<Customer>().Reaction(10);
            orderText.text = obj.GetComponent<Customer>().getNowComment();
            Invoke("TextboxDown", 1.5f);
        }
    }

    void TextboxDown()
    {
        textBox.transform.position = new Vector2(textBox.transform.position.x, textBox.transform.position.y - 1000);

    }


}