using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{

    public enum ShapeType { Sphere, Cube, Torus };
    public enum Operation { None, Blend}

    public ShapeType shapeType;
    public Operation operation;
    public Color colour = Color.white;
    [Range(0, 1)]
    public float blendStrength;
    [HideInInspector]
    public int numChildren;

    public bool Move;


    public Vector3 Position
    {
        get
        {
            return transform.position;
        }
    }

    public Color col
    {
        get
        {
            return transform.GetComponent<Renderer>().material.color;
        }
    }

    public Vector3 Scale
    {
        get
        {
            Vector3 parentScale = Vector3.one;
            if (transform.parent != null && transform.parent.GetComponent<Shape>() != null)
            {
                parentScale = transform.parent.GetComponent<Shape>().Scale;
            }
            return Vector3.Scale(transform.localScale, parentScale);
        }
    }

    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        if (Move)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time / 4, 3f) + 7);
        }
    }
}
