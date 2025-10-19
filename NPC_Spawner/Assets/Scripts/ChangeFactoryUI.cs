using UnityEngine;
using UnityEngine.UI;

public class ChangeFactoryUI : MonoBehaviour
{
    public GameObject village;
    public Button vilageButton;
    public GameObject city;
    public Button cityButton;
    public GameObject town;
    public Button townButton;

    public void ChangeToVillage()
    {
        village.SetActive(true);
        vilageButton.interactable = false;
        city.SetActive(false);
        cityButton.interactable = true;
        town.SetActive(false);
        townButton.interactable = true;
    }

    public void ChangeToCity()
    {
        village.SetActive(false);
        vilageButton.interactable = true;
        city.SetActive(true);
        cityButton.interactable = false;
        town.SetActive(false);
        townButton.interactable = true;
    }
    
    public void ChangeToTown()
    {
        village.SetActive(false);
        vilageButton.interactable = true;
        city.SetActive(false);
        cityButton.interactable = true;
        town.SetActive(true);
        townButton.interactable = false;
    }
}
