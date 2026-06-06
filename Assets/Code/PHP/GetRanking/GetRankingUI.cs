using UnityEngine;
using TMPro;

public class GetRankingUI : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform container;
    [SerializeField] private GetRankingController controller;

    private void Awake()
    {
        controller = GetComponent<GetRankingController>();
    }

    public void Send()
    {
        controller.Send(OnResult);
    }

    private void OnResult(PlayerResultData result)
    {
        if(result.data.Length > 0)
        {
            foreach (PlayerData player in result.data)
            {
                GameObject item = Instantiate(prefab, container);
                item.GetComponent<TextMeshProUGUI>().text = $"{player.user_name} - {player.user_score}";
            }
        }
    }


}
