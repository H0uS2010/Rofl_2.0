using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public Text endText;

    public void Lose()
    {
        endText.text = "YOU DEAD";
        endText.color = Color.red;
        StartCoroutine(Restart());


   }


    public void Win()
    {
        endText.text = "YOU WIN";
        endText.color = new Color(0, 1, 0);
        StartCoroutine(Restart());

    }
    IEnumerator Restart()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
