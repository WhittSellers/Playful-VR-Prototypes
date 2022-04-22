using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLayerChange : MonoBehaviour
{
    public GameObject _interactable;
    public GameObject _table;
    
    void OnTriggerEnter(Collider other)
    {
        _table.layer = 1;
        _interactable.layer = 1;
    }
}
