using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    public Animator animator;
    public MeshRenderer mesh;
    public Material material;

    public bool Toggle;
    public bool anim;

    public Vector3 oPos;
    public Transform endRef;
    public Vector3 fPos;

    public float distance;
    public Vector3 desiredPos;
    public int desiredT = 1;
    // Start is called before the first frame update
    void Start()
    {
        oPos = transform.position;
        anim = !anim;
        mesh = GetComponent<MeshRenderer>();
        material = mesh.material;
    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetBool("On", Toggle);
        Move();
      
    }
    void Move()
    {
        distance = Vector3.Distance(transform.position, desiredPos);

        if (distance == 0)
        {
            desiredT *= -1;
        }
        if (desiredT > 0)
            desiredPos = endRef.position;
        else
            desiredPos = oPos;

        transform.position = Vector3.MoveTowards(transform.position, desiredPos, .1f * Time.deltaTime);

        //transform += transform.forward * 1;

    }

}
