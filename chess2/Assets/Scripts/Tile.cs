using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor;

    [SerializeField] private SpriteRenderer _renderer;

    [SerializeField] private GameObject _highlight, _moveHighlight;

    [SerializeField] private bool _moveable;
    
    // Set tile color on intialization in GridManager script
    public void Init(bool isOffset)
    {
        // Change the tile color according to isOffset
        _renderer.color = isOffset ? _offsetColor : _baseColor;
    }

    public void HighlightOn() 
    {
        _highlight.SetActive(true);
    }

    public void HighlightOff() 
    {
        _highlight.SetActive(false);
    }

    public void MoveHighlightOn() 
    {
        _moveHighlight.SetActive(true);
        _moveable = true;

    }

    public void MoveHighlightOff() 
    {
        _moveHighlight.SetActive(false);
        _moveable = false;
    }

    // _ tile when mouse enters
    void OnMouseEnter()
    {
        HighlightOn();
    }

    // Remove tile _ when mouse exits
    void OnMouseExit()
    {
        HighlightOff();
    }

    void OnMouseDown()
    {
        Debug.Log(gameObject.name);

        if (_moveable) 
        {
            Debug.Log("Moveable");
        }
    }
}
