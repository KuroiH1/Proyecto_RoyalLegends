using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLevels : MonoBehaviour
{
    public void Level1()
    {
        // Carga la escena del juego
        SceneManager.LoadScene("JUEGO_PRINCIPAL");
    }

    public void Level2()
    {
        // Carga la escena
        SceneManager.LoadScene("Game");
    }

    public void Level3()
    {
        // Carga la escena
        SceneManager.LoadScene("Game");
    }

    public void Volver()
    {
        // Carga la escena del Menu Principal
        SceneManager.LoadScene("MENU_PRINCIPAL");
    }

    public void Arena()
    {
        // Carga la escena del Menu Arena
        SceneManager.LoadScene("MenuArena");
    }
}