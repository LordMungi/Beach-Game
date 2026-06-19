using System.Collections.Generic;
using UnityEngine;

public class Parasol : MonoBehaviour
{
    public List<Item> itemsOnShade;

    void Start()
    {
        itemsOnShade = new List<Item>();
    }

    private void OnTriggerEnter(Collider other)
    {
        itemsOnShade.Add(other.GetComponent<Item>());
        //Debug.Log("Add " + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        itemsOnShade.Remove(other.GetComponent<Item>());
        //Debug.Log("Remove " + other.name);
    }
}
