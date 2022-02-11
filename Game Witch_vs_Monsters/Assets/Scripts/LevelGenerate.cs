using System.Collections.Generic;
using UnityEngine;

public class LevelGenerate : MonoBehaviour
{

    public GameObject[] RoadPrefabs;
    [SerializeField] private Transform Player;
    private List<GameObject> Road = new List<GameObject>();
    public GameObject StartRoad;

    public float PrefabDistance = 78;
    private int StartGenerate = 5;



    private void Start()
    {
        for (int i = 0; i < StartGenerate; i++)
        {
            GenerateRoad(Random.Range(0, RoadPrefabs.Length));

        }
    }

    private void Update()
    {
        if (Player != null && Player.position.z - 80 > PrefabDistance - (StartGenerate * 100))
        {
            GenerateRoad(Random.Range(0, RoadPrefabs.Length));
            DeleteRoad();
        }

    }


    private void GenerateRoad(int IndexRoad)
    {
        GameObject RoadPart = Instantiate(RoadPrefabs[IndexRoad], transform.forward * PrefabDistance, transform.rotation);
        Road.Add(RoadPart);
        PrefabDistance = PrefabDistance + 100;
    }

    private void DeleteRoad()
    {
        Destroy(Road[0]);
        Road.RemoveAt(0);
    }


}
