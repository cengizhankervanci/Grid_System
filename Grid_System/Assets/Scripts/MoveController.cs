using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public GameObject Player;
    public GameObject target;
    Vector3 truePos;
    void LateUpdate()
    {
        truePos.x = Mathf.Floor(target.transform.position.x);
        truePos.y = 0.5f;
        truePos.z = Mathf.Floor(target.transform.position.z);
        Player.transform.position = truePos;
    }
}
