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

        if (Input.GetKeyDown(KeyCode.UpArrow)) //이제 위쪽 화살표 말고 게임 시작 | 앞 고객 완료 되면 객체 생성
        {
            //customer 랜덤뽑기
            obj=Instantiate(customers[0], spawnPoint.position, spawnPoint.rotation,GameObject.Find("Canvas").transform);
            orderText.text = obj.GetComponent<Customer>().comment[0];
            textBox.transform.position = new Vector2(textBox.transform.position.x, textBox.transform.position.y+300);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) //아래쪽 화살표 말고 만족도가 -1이 아니면 리액션 후 객체 삭제
        {
            obj.GetComponent<Customer>().Reaction(10);
            orderText.text = obj.GetComponent<Customer>().comment[1];
            Invoke("TextboxDown", 1f);
        }
    }

    void TextboxDown()
    {
        textBox.transform.position = new Vector2(textBox.transform.position.x, textBox.transform.position.y -300);

    }


}
