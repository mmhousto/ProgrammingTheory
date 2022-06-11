using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCircle : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        SetProperties("Sphere", Color.green);
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    protected override void DisplayText()
    {
        nameLabel.text = $"You clicked the left shape: {ShapeName}";
    }
}
