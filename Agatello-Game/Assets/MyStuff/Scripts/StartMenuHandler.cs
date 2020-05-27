using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Дает доступ манеджеру сцен.

public class StartMenuHandler : MonoBehaviour
{
    //public bool IsBottomPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // функция опредиляет сцену на которую мы будем ссылаться
    public void StartButtonPressed(){
        SceneManager.LoadScene("MainScene");

    }

    public void ExitButtonPressed(){
        Debug.Log("You leave a game");
        Application.Quit();
        
    }
   public void SetPanelOn(GameObject panel) {
       //mainPanel.SetActive(false);
       panel.SetActive(true);

   }
   public void SetPanelOff(GameObject panel) {
       panel.SetActive(false);
       //infoPanel.SetActive(true);

   }
    
}
