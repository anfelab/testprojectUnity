using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfGrounded : MonoBehaviour
{
    public Collider playerCollider;
    public bool isGrounded;
    public bool isOnTerrain;
    public LayerMask GroundLayers;

    RaycastHit hit;
    void Update()
    {
        isGrounded = PlayerGrounded();
        isOnTerrain = CheckOnTerrain();
    }
    bool PlayerGrounded()
    {
        
        return Physics.Raycast(transform.position, Vector3.down, out hit, playerCollider.bounds.extents.y + 0.5f, GroundLayers);
    }

    bool CheckOnTerrain ()
    {
        if (hit.collider != null && hit.collider.tag == "Terrain")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
