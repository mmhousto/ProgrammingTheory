using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class GreenCircle : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        // ABSTRACTION
        SetProperties("Sphere", Color.green);
    }

    private void OnMouseDown()
    {
        // ABSTRACTION
        DisplayText();
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        nameLabel.text = $"You clicked the left shape: {ShapeName}";
    }
}
