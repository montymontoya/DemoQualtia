using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BzKovSoft.ObjectSlicer;
public class Cutter : MonoBehaviour
{
    public Plane plane;
    private void OnTriggerEnter(Collider other)
    {
        Cut(other.gameObject);
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
            return;
        }
        Plane plane = new Plane(Vector3.right, 0f);
        slice.Slice(plane, 1, null);
    }
}
