using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuArena : MonoBehaviour
{
   public void Arena1()
   {
    SceneManager.LoadScene("Arena1");
   }

   public void Arena2()
   {
    SceneManager.LoadScene("Arena2");
   }
   
   public void Arena3()
   {
    SceneManager.LoadScene("Arena3");
   }

   public void Volver()
   {
    SceneManager.LoadScene("MenuLevels");
   }
}
