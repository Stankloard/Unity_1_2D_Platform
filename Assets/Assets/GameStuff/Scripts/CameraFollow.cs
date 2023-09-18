using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;

    private Vector3 temPos;

    [SerializeField]
    private float minX, maxX;

    [SerializeField]
    private float minY, maxY;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void LateUpdate()
    {
        if (!player)
            return;

        temPos = transform.position;
        temPos.x = player.position.x;
        temPos.y = (player.position.y / 1.6f);

        if (temPos.x < minX)
            temPos.x = minX;

        if (temPos.x > maxX)
            temPos.x = maxX;

        if (temPos.y < minY)
            temPos.y = minY;

        if (temPos.y > maxY)
            temPos.y = maxY;

        transform.position = temPos;
    }
}
