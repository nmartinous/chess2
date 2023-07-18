using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _whitePawnPrefab;
    [SerializeField] private GameObject _blackPawnPrefab;

    void Start()
    {
        for (int i = 0; i <= 7; i++)
        {
            var whitePawn = Instantiate(_whitePawnPrefab, new Vector3(i, 1, -1), Quaternion.identity);
            whitePawn.name = $"White Pawn {i} 1";
            var blackPawn = Instantiate(_blackPawnPrefab, new Vector3(i, 6, -1), Quaternion.identity);
            blackPawn.name = $"Black Pawn {i} 7";
        }
    }
}
