using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    public TextMeshProUGUI nameLabel;

    // ENCAPSULATION
    public string ShapeName { get; protected set; }
    public Color ShapeColor { get; protected set; }

    private void OnMouseDown()
    {
        DisplayText();
    }

    // POLYMORPHISM
    protected virtual void DisplayText()
    {
        nameLabel.text = ShapeName;
    }

    // ABSTRACTION
    protected void SetProperties(string name, Color color)
    {
        ShapeName = name;
        ShapeColor = color;
        GetComponent<Renderer>().material.color = ShapeColor;
    }
}
