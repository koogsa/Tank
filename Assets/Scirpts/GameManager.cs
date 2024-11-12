using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;    // 싱글톤 인스턴스
    public GameObject playAgainButton;     // Play Again 버튼 오브젝트
    public TankController tank1;           // 탱크 1의 TankController
    public TankController tank2;           // 탱크 2의 TankController

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
        // 게임 오버 시 Play Again 버튼 활성화
        playAgainButton.SetActive(true);
    }

    public void PlayAgain()
    {
        // Play Again 버튼을 클릭 시 게임 초기화
        playAgainButton.SetActive(false);

        // 각 탱크를 초기화 후 활성화
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
