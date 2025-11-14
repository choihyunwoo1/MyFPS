using UnityEngine;

namespace Mysample
{
    /// <summary>
    /// Y Bot을 제어하는 클래스
    /// 인풋 시스템 - 올드 인풋 시스템 사용 
    /// W키를 누르면 걷기 애니메이션 픓레이, 걷기 하는동안 Shift키 누를 경우 달리는 애니메이션 실행
    /// </summary>
    public class YBotController : MonoBehaviour
    {
        [Header("컴포넌트 참조")]
        private Animator animator; //애니메이터

        // 상태 변수
        private bool isWalking = false;
        private bool isRunning = false;

        private void Awake()
        {
            //참조
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            HandleInput();
        }

        private void HandleInput()
        {
            // W키로 걷기 시작
            if (Input.GetKey(KeyCode.W))
            {
                isWalking = true;

                // 걷는 중에 Shift를 누르면 달리기
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    isRunning = true;
                }
                else
                {
                    isRunning = false;
                }
            }
            else
            {
                // 키를 떼면 멈춤
                isWalking = false;
                isRunning = false;
            }

            // 애니메이터 파라미터 반영
            animator.SetBool("IsWalk", isWalking);
            animator.SetBool("IsRun", isRunning);
        }
    }
}