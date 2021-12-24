using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerate : MonoBehaviour
{
    public GameObject[] section;
    public float zPos = 0;
    public float sectionLength = 39.5f;
    public bool createSection = false;
    public int secNum;

    public int numberOfSection = 3;

    public Transform playerTranform;
    private List<GameObject> activeSection = new List<GameObject>();

    void Start()
    {
        for(int i = 0; i < numberOfSection; i++)
        {
            if (i == 0)
            {
                SpawnSection(0);
            }
            SpawnSection(Random.Range(0,section.Length));
        }
    }
    void Update()
    {
        if (playerTranform.position.z - 42 > zPos - (numberOfSection * sectionLength))
        {
            SpawnSection(Random.Range(0,section.Length));
            DeleteSection();
        }
    }

    public void SpawnSection(int secNum)
    {
        GameObject go = Instantiate(section[secNum], transform.forward*zPos,transform.rotation);
        activeSection.Add(go);
        zPos += sectionLength;
    }
    
    private void DeleteSection()
    {
        Destroy(activeSection[0]);
        activeSection.RemoveAt(0);
    }
}
