using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class RedCube : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        // ABSTRACTION
        SetProperties("Cube", Color.red);
    }

    private void OnMouseDown()
    {
        // ABSTRACTION
        DisplayText();
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        nameLabel.text = $"You clicked the middle shape: {ShapeName}";
    }
}
