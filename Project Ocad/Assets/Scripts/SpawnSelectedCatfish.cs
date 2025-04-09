using UnityEngine;

public class SpawnSelectedCatfish : MonoBehaviour
{
    [SerializeField] private StepSO[] catfishSO;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SelectedCatfish();
    }


    void SelectedCatfish()
    {
        int selectedCatfish = PlayerPrefs.GetInt("SelectedStep");
        GameObject spawnedCatfish = Instantiate(catfishSO[selectedCatfish].stepPrefab, transform.position, Quaternion.identity);
        spawnedCatfish.transform.SetParent(transform);
    }
}
