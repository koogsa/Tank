using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // 스코어를 표시하는 TextMeshProUGUI
    private int tank1Score = 0;
    private int tank2Score = 0;

    public void AddScore(int tankNumber)
    {
        if (tankNumber == 1)
        {
            tank2Score++;  // 탱크1이 파괴되면 탱크2의 점수를 증가
        }
        else if (tankNumber == 2)
        {
            tank1Score++;  // 탱크2가 파괴되면 탱크1의 점수를 증가
        }

        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = tank1Score + " : " + tank2Score;  // "1 : 0" 형식으로 스코어 표시
    }
}
