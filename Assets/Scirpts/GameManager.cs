using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;    // �̱��� �ν��Ͻ�
    public GameObject playAgainButton;     // Play Again ��ư ������Ʈ
    public TankController tank1;           // ��ũ 1�� TankController
    public TankController tank2;           // ��ũ 2�� TankController

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GameOver()
    {
        // ���� ���� �� Play Again ��ư Ȱ��ȭ
        playAgainButton.SetActive(true);
    }

    public void PlayAgain()
    {
        // Play Again ��ư�� Ŭ�� �� ���� �ʱ�ȭ
        playAgainButton.SetActive(false);

        // �� ��ũ�� �ʱ�ȭ �� Ȱ��ȭ
        if (tank1 != null)
        {
            tank1.ResetTank();
        }

        if (tank2 != null)
        {
            tank2.ResetTank();
        }
    }
}
