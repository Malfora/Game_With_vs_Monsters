using UnityEngine;

public class MageAttack : MonoBehaviour
{
    public Rigidbody MageBall;
    public float BallSpeed = 25;

    private Vector3 StartPosition;
    private float XDistance = 0;
    public float AttackLenght = 3;


    private void Start()
    {
        MageBall.velocity = MageBall.transform.forward * BallSpeed;
        StartPosition = MageBall.transform.position;
        
    }
    private void Update()
    {
        PassedWay();
    }

    public void PassedWay()
    {
        var PassWayZ = Mathf.Abs(transform.position.z - StartPosition.z);
        //Debug.Log(PassWayZ + "����������");

        StartPosition = transform.position;
        //Debug.Log(StartPosition.z + "������ ��� ����� ������");

        XDistance += PassWayZ;
        //Debug.Log(PassWayZ + "����� �����������");

        if (XDistance >= AttackLenght)
        {
            Destroy(this.gameObject);
            //Debug.Log("������ ���������");
        }
    }
    
    public void OnTriggerEnter(Collider other)
    {
        
        Destroy(gameObject);
        Debug.Log("������������ �����");

    }


}
