using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentTransform : MonoBehaviour
{
    public GameObject parentGO;

    public GameObject childGO;
    Transform _parentTransform;
    bool isGrabbed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        if(parentGO)
        {
            _parentTransform = parentGO.GetComponent<Transform>();
            SetTransform();
        }
    }

    public void ActivateIsGrabbed()
    {
        isGrabbed = true;
        if(parentGO)
        {
            SetTransform();
        }
    }

    public void SetTransform()
    {
        if(!isGrabbed)
        {
            this.transform.SetParent(_parentTransform, false);
        }
        if(isGrabbed)
        {
            this.transform.SetParent(_parentTransform, true);
        }
    }

    public void SetLayerMask()
    {
        if(isGrabbed)
        {
            childGO.layer = 0;
        }
        else
        {
            childGO.layer = 6;
        }
    }
}
