using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class pindahscene : MonoBehaviour
{
   public void Onclickpindahscene()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1  );
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
