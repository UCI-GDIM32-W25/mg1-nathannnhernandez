using UnityEngine;
using TMPro;
//im tryna make this shi compile
//why does it not build bru

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _remainingText.text = seedsLeft.ToString();
        _plantedText.text = seedsPlanted.ToString();
    }
}