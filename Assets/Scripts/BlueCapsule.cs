using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class BlueCapsule : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        // ABSTRACTION
        SetProperties("Capsule", Color.blue);
    }

    private void OnMouseDown()
    {
        // ABSTRACTION
        DisplayText();
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        nameLabel.text = $"You clicked the right shape: {ShapeName}";
    }
}
