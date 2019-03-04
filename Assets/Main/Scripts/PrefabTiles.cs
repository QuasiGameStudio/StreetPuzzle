using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTiles : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject[] tiles;
    private GameObject[] items;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetTile(int index){
        return tiles[index];
    }

    public GameObject GetItem(int index){
        return items[index];
    }
}
