using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        SetProperties("Cube", Color.red);
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    protected override void DisplayText()
    {
        nameLabel.text = $"You clicked the middle shape: {ShapeName}";
    }
}
