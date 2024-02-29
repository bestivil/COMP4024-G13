using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    ToggleGroup toggleGroup;
    

    void Start(){
        toggleGroup = GetComponent<ToggleGroup>();
    }

    public void onClick(){
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
        Debug.Log(toggle.name + "_" + toggle.GetComponentInChildren<Text>().text);
        SceneManager.LoadScene("CosmicWordQuest"); // Load the game scene
    }
}
