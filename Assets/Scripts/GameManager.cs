 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BzKovSoft.ObjectSlicer;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public GameManager()
    {
        instance = this;
    }

    public void Cut(GameObject other)
    {
        var slice = other.GetComponent<IBzSliceableAsync>();
        if (slice == null)
        {
            slice = other.GetComponentInParent<IBzSliceableAsync>();

        }
        if (slice == null)
        {
            Debug.Log("NULO");
            return;
        }
        else
        {
            Debug.Log("SLICEABLE");

        }
        Plane plane = new Plane(Vector3.right, 0f);
        slice.Slice(plane, 1, null);
    }
}
