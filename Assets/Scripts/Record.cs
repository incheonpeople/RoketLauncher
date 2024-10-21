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
        // �ְ� ��� �ҷ����� (PlayerPrefs���� ����� �� �ҷ�����)
        highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        UpdateHighScoreUI();
    }

    private void Update()
    {
        // ������ ���� �̵� �Ÿ��� ��� (���⼭�� �ð��� ����� ������ ����)
        currentScore += Time.deltaTime * 10;  // ���÷� 1�ʴ� 10 ������ �̵��Ѵٰ� ����
        UpdateCurrentScoreUI();

        // �ְ� ��� ����
        if (currentScore > highScore)
        {
            highScore = currentScore;
            UpdateHighScoreUI();

            // ���ο� �ְ� ����� ����
            PlayerPrefs.SetFloat("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }

    private void UpdateCurrentScoreUI()
    {
        // ���� ������ UI�� ǥ��
        currentScoreTxt.text = $"{currentScore:F1} M";  // �Ҽ��� �� �ڸ����� ǥ��
    }

    private void UpdateHighScoreUI()
    {
        // �ְ� ����� UI�� ǥ��
        highScoreTxt.text = $"High Score: {highScore:F1} M";
    }
}

