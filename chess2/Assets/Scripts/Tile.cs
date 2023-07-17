using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor;

    [SerializeField] private SpriteRenderer _renderer;

    [SerializeField] private GameObject _highlight;

    // Set tile color on intialization in GridManager script
    public void Init(bool isOffset)
    {
        // Change the tile color according to isOffset
        _renderer.color = isOffset ? _offsetColor : _baseColor;
    }

    // Highlight tile when mouse enters
    void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    // Remove tile highlight when mouse exits
    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }

    void OnMouseDown()
    {
        Debug.Log(gameObject.name);
    }
}
