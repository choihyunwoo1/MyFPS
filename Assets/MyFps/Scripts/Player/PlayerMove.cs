using UnityEngine;

namespace MyFps
{
    /// <summary>
    /// 플레이어 이동을 관리하는 클래스
    /// </summary>
    public class PlayerMove : MonoBehaviour
    {
        #region Variables
        //참조
        private CharacterController _controller;    //캐릭터 컨트롤러
        private CharacterInput _input;              //플레이어 인풋

        //Header 특성 : 직렬화된 속성들의 설명 글
        [Header("Player")]      
        //이동
        [SerializeField]
        private float moveSpeed = 4f;       //걷는 속도
        [SerializeField]
        private float sprintSpeed = 6f;     //뛰는 속도
        private float speed;                //이동 속도

        //점프
        [SerializeField] float jumpHeight = 1.2f; //점프 입력시 점프할 높이
        [SerializeField] float gravity = -15.0f; //중력,물리 기본값(-9.81f)
        [SerializeField] float jumpTimeout = 0.1f; //점프 키입력 처리
        [SerializeField] float verticalVelocity; //y축의 속도 연산 결과

        [Header("Player Ground")]
        //그라운드 체크
        [SerializeField] bool grounded = false;
        [SerializeField] float groundedOffset = -0.14f; //체크 포지션 조정값
        [SerializeField] float groundedRadius = 0.5f; //체크 포지션을 기준으로 체크 범위 영역
        public LayerMask groundLayers; //그라운드 레이어 설정
        #endregion

        #region Unity Event Method
        private void Awake()
        {
            //참조
            _controller = GetComponent<CharacterController>();
            _input = GetComponent<CharacterInput>();
        }

        private void Update()
        {
            JumpGravity();
            GroundedCheck();
            Move();
        }
        #endregion

        #region CustomMethod
        //DrawGizmo
        private void OnDrawGizmosSelected()
        {
            if (grounded)
            {
                Gizmos.color = new Color(0f, 1f, 0f, 0.35f);
            }
            else
            {
                Gizmos.color = new Color(1f, 0f, 0f, 0.35f);
            }
            Vector3 spherePosition = new Vector3(transform.position.x,
                                        transform.position.y + groundedOffset,
                                        transform.position.z);
            Gizmos.DrawSphere(spherePosition, groundedRadius);
        }
        //점프
        void JumpGravity()
        {
            if (grounded)
            {
                //verticalVelocity 중첩 방지 초기화
                if (verticalVelocity < 0.0f)
                {
                    verticalVelocity = -2f;
                }
                //점프 입력 체크
                if (_input.Jump && jumpTimeout <= 0f)
                {
                    //jumpHeight(1.2f) 만큼 뛰기 위한 속도값 구하기
                    verticalVelocity = Mathf.Sqrt(jumpHeight * -2.0f * gravity);
                }
                //점프 타이머
                if (jumpTimeout >= 0f)
                { 
                    jumpTimeout -= Time.deltaTime;
                }
            }
            else
            {
                jumpTimeout = 0.1f;
                _input.Jump = false;
            }

            //중력 적용
            verticalVelocity += gravity * Time.deltaTime;

        }

        //그라운드 체크
        void GroundedCheck()
        {
            //그라운드 체크 값 가져오기
            //grounded = _controller.isGrounded;

            Vector3 spherePosition = new Vector3(transform.position.x,
                                         transform.position.y + groundedOffset,
                                         transform.position.z);

            grounded = Physics.CheckSphere(
                spherePosition,
                groundedRadius,
                groundLayers,
                QueryTriggerInteraction.Ignore
            );
        }

        //캐릭터 이동
        private void Move()
        {
            speed = _input.Sprint ? sprintSpeed : moveSpeed;

            // 이동 방향
            Vector3 inputDirection =
                transform.right * _input.Move.x +
                transform.forward * _input.Move.y;

            // 수평 이동
            Vector3 horizontal = inputDirection * speed;

            // 수직 이동 (중력/점프)
            Vector3 vertical = new Vector3(0f, verticalVelocity, 0f);

            // 최종 이동
            _controller.Move((horizontal + vertical) * Time.deltaTime);
        }
        #endregion
    }
}