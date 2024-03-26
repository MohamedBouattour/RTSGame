using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject skillUI;
    void Start()
    {

    }
    void Update()
    {
        // Check if the "B" key is pressed
        if (Input.GetKeyDown(KeyCode.B))
        {
            // Toggle the visibility of the skill UI
            if (skillUI != null)
            {
                skillUI.SetActive(!skillUI.activeSelf);
            }
        }
    }
}
