using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody Player;
    public float PlayerSpeed;

    private int PlayersLife = 2;
    public Text PlayerLifeText;

    public GameObject EndMenu;
    public GameObject MineGameMenu;
    

    private void Start()
    {
        EndMenu.SetActive(false);
        Player = GetComponent<Rigidbody>();
        LifePrintText();
    }

    private void FixedUpdate()
    {
        //движение игрока
        Vector3 MoveVector = new Vector3(0, 0, 1);
        MoveVector = MoveVector.normalized * PlayerSpeed * Time.deltaTime;

        Player.MovePosition(transform.position + MoveVector);
    }

    public void RightButton() //движение вправо
    {
        if (Player.position.x <= 1)
        {
            Player.transform.position = new Vector3(Player.position.x + 3, 0, Player.position.z);
        }
        Debug.Log("Правая кнопка нажата");
    }

    public void LeftButton() //движение влево
    {
        if (Player.position.x >= -1)
        {
            Player.transform.position = new Vector3(Player.position.x - 3, 0, Player.position.z);
        }
        Debug.Log("Левая кнопка нажата");
    }
    public void OnTriggerEnter(Collider other) //столкновение и получение урона
    {
        Debug.Log("Столкновение с врагом");
        if (PlayersLife > 0)
        {
            PlayersLife -= 1;
            LifePrintText();

        }
        else if (PlayersLife <= 0)
        {
            Destroy(gameObject);
            LifePrintText();
            EndMenu.SetActive(true);
            MineGameMenu.SetActive(false);
        }
    }

    
    

    public void LifePrintText() //вывод количества жизней
    {
        PlayerLifeText.text = " " + (PlayersLife + 1);
    }
}
