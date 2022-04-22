using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneReset : MonoBehaviour
{
    public void OnReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
