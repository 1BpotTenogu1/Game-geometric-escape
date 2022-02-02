using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorLvl : MonoBehaviour
{
    public GameObject[] Level;
    public int PosZ = 20;
    public bool creatingLeve = false;
    public int LvlNum;

    void Start()
    {
        ResetLevel();
        StartLevel();
    }

    void Update()
    {
       if(creatingLeve == false)
        {
            creatingLeve = true;
            StartCoroutine(GeneratorLevels());
        } 
    }

    public void ResetLevel()
    {

    }

    public void StartLevel()
    {
        
    }

    IEnumerator GeneratorLevels()
    {
        LvlNum = Random.Range(0, 3);
        Instantiate(Level[LvlNum], new Vector3(0, 0, PosZ), Quaternion.identity);
        PosZ += 20;
        yield return new WaitForSeconds(2.5f);
        creatingLeve = false;
    }

}
