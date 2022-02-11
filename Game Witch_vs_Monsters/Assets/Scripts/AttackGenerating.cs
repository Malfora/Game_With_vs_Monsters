using UnityEngine;

public class AttackGenerating : MonoBehaviour
{
    public GameObject MagicBall;
    public Transform Staff;

    public void AttackButton()
    {

        Instantiate(MagicBall, Staff.position, Staff.rotation);

        Debug.Log("Магический выстрел");
    }


}
