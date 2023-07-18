using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    [SerializeField] private GameObject _highlight;

    private GameObject[] _tilePositions;

    //public bool active = false;

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

        _tilePositions = GameObject.FindGameObjectsWithTag("Tile");

        /*foreach (GameObject tilePosition in _tilePositions)
        {
            tilePosition.GetComponent<Tile>().MoveHighlightOff();

            if (tilePosition.transform.position == new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, 0) && gameObject.tag == ("White"))
            {
                tilePosition.GetComponent<Tile>().MoveHighlightOn();
            } 
            else if (tilePosition.transform.position == new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 2, 0) && gameObject.tag == ("White"))
            {
                tilePosition.GetComponent<Tile>().MoveHighlightOn();
            } 
            if (tilePosition.transform.position == new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, 0) && gameObject.tag == ("Black"))
            {
                tilePosition.GetComponent<Tile>().MoveHighlightOn();
            } 
            if (tilePosition.transform.position == new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 2, 0) && gameObject.tag == ("Black"))
            {
                tilePosition.GetComponent<Tile>().MoveHighlightOn();
            } 
        }*/
    }
}
