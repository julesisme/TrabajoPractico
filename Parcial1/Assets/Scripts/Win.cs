using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour

{
    public PauseMenu pausemenu;
    public GameObject pausecanvas;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Gracias por jugar :)");

        customCanvas.SetActive (true);

        pausemenu.Pausegame();
        pausecanvas.SetActive (false);
    }
    /// 

    public void ToMainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    ///

    [SerializeField] private GameObject customCanvas;

    void OnTriggerEnter(Collider other)
    {

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
        }
    }
}
