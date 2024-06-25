using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    [SerializeField] private Text descriptionText;

    protected private void ShapeDescription()
    {
        descriptionText.text = "Text";
    }
}
