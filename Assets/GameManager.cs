using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   bool gameHasEnded = false; // game over is constrained to a boolean ( loads only once )
   public float restartDelay = 1; // this variable offsets the restart function providing a slight delay


   public GameObject CompleteLevelUI;

   public void EndGame()
   {
       if(gameHasEnded == false)
       {
           gameHasEnded = true;
           Debug.Log("Game Over");
           Invoke("Restart", restartDelay);
           
           //call restart function and restart the current scene
           Restart();

       }
   }

   void Restart()
   {
       // grab the name of the current scene and loads it via the scene manager
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void CompleteLevel()
   {
       CompleteLevelUI.SetActive(true);
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);   

   }
     public void CompleteLevel2()
   {
       CompleteLevelUI.SetActive(true); 
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   
   }
}


