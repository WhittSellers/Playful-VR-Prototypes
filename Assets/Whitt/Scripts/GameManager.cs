using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject instructionUI;
    public GameObject endGameUI;

    public List<GameObject> puzzleCubes;
    
    private bool cube1 = false;
    private bool cube2 = false;
    private bool cube3 = false;

    private GameManager instance;

    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    void Start()
    {
        endGameUI.SetActive(false);
        instructionUI.SetActive(true);

        puzzleCubes[0].SetActive(true);
        puzzleCubes[1].SetActive(false);
        puzzleCubes[2].SetActive(false);
    }

    public void CubeOneFound()
    {
        cube1 = true;
        instructionUI.SetActive(false);
        puzzleCubes[1].SetActive(true);
    }

    public void CubeTwoFound()
    {
        cube2 = true;
        puzzleCubes[2].SetActive(true);
    }

    public void CubeThreeFound()
    {
        cube3 = true;
        EndGame();
    }

    public void EndGame()
    {
        endGameUI.SetActive(true);
    }
}
