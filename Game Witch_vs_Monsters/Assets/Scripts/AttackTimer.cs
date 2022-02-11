using UnityEngine;
using UnityEngine.UI;

public class AttackTimer : MonoBehaviour
{
    private float StartTimer = 4;
    public float TimerTime;
    public Text TimerText;
    public bool Cooldown = false;
    public Button Attackbutton;

    private void Update()
    {
        if (Cooldown == true)
        {
            
            StartTimer -= Time.deltaTime;
            TimerText.text = (Mathf.Round(StartTimer)+1).ToString() ;
            Attackbutton.interactable = false;

        }

        if (StartTimer < 0)
        {
            StartTimer = 0;
            TimerText.text = "0";
            Attackbutton.interactable = true;
            Cooldown = false;
            StartTimer = TimerTime;

        }
    }

    public void CooldjwnTimer()
    {
        Cooldown = true;
    }

}
