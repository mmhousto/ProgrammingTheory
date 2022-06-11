using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCapsule : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        SetProperties("Capsule", Color.blue);
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    protected override void DisplayText()
    {
        nameLabel.text = $"You clicked the right shape: {ShapeName}";
    }
}
