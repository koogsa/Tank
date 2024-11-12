using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // ���ھ ǥ���ϴ� TextMeshProUGUI
    private int tank1Score = 0;
    private int tank2Score = 0;

    public void AddScore(int tankNumber)
    {
        if (tankNumber == 1)
        {
            tank2Score++;  // ��ũ1�� �ı��Ǹ� ��ũ2�� ������ ����
        }
        else if (tankNumber == 2)
        {
            tank1Score++;  // ��ũ2�� �ı��Ǹ� ��ũ1�� ������ ����
        }

        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = tank1Score + " : " + tank2Score;  // "1 : 0" �������� ���ھ� ǥ��
    }
}
