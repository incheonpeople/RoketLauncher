using TMPro;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentScoreTxt;
    [SerializeField] private TextMeshProUGUI highScoreTxt;

    private float currentScore = 0f;
    private float highScore = 0f;

    private void Start()
    {
        // 최고 기록 불러오기 (PlayerPrefs에서 저장된 값 불러오기)
        highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        UpdateHighScoreUI();
    }

    private void Update()
    {
        // 로켓의 현재 이동 거리를 계산 (여기서는 시간에 비례한 값으로 가정)
        currentScore += Time.deltaTime * 10;  // 예시로 1초당 10 단위로 이동한다고 가정
        UpdateCurrentScoreUI();

        // 최고 기록 갱신
        if (currentScore > highScore)
        {
            highScore = currentScore;
            UpdateHighScoreUI();

            // 새로운 최고 기록을 저장
            PlayerPrefs.SetFloat("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }

    private void UpdateCurrentScoreUI()
    {
        // 현재 점수를 UI에 표시
        currentScoreTxt.text = $"{currentScore:F1} M";  // 소수점 한 자리까지 표시
    }

    private void UpdateHighScoreUI()
    {
        // 최고 기록을 UI에 표시
        highScoreTxt.text = $"High Score: {highScore:F1} M";
    }
}

