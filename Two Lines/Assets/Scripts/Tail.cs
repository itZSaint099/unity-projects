﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
[RequireComponent(typeof(EdgeCollider2D))]

public class Tail : MonoBehaviour
{
    public float pointSpacing = 0.1f;
    public Transform head;

    // Transform snake;

    List<Vector2> points;

    LineRenderer line;
    EdgeCollider2D col;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
        col = GetComponent<EdgeCollider2D>();

        points = new List<Vector2>();

        SetPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(points.Last(), head.position) > pointSpacing)
        {
            SetPoint();
        }

    }

    void SetPoint()
    {
        col.points = points.ToArray<Vector2>();

        points.Add(head.position);

        line.positionCount = points.Count;
        line.SetPosition(points.Count - 1, head.position);

    }
}
