using UnityEngine;

namespace Mysample
{
    public class BlendTreeTest : MonoBehaviour
    {
        #region Variables
        //참조
        Animator animator;

        //이동속도
        [SerializeField] float moveSpeed = 5f;

        //입력 값
        float moveX;
        float moveY;
        
        // 파라미터
        string MoveState = "MoveState";
        string MoveX = "MoveX";
        string MoveY = "MoveY";
        #endregion

        #region Unity Event Method
        private void Awake()
        {
            //참조
            animator = GetComponent<Animator>();
        
        }
        private void Update()
        {
            //WASD 입력값 처리
            moveX = Input.GetAxis("Horizontal"); // -1 ~ 0 ~ 1 사이의 값
            moveY = Input.GetAxis("Vertical"); // -1 ~0 ~1 사이의 값

            //이동, 방향과 속도
            //입력방향
            Vector3 dir = new Vector3 (moveX, 0f, moveY);
             transform.Translate(dir.normalized * Time.deltaTime * moveSpeed, Space.World);

            //애니메이션 파라미터 셋팅
            //AnimateState();
            AnimateBlendTree();
        }
        #endregion

        #region Custom Method
        public void AnimateBlendTree()
        { 
            animator.SetFloat(MoveX, moveX);
            animator.SetFloat(MoveY, moveY);


        }
        public void AnimateState()
        { 
            if(moveX == 0f && moveY == 0f)
            {
                animator.SetInteger(MoveState, 0); // idle(대기)
            }
            if (moveY > 0f)
            { 
                animator.SetInteger (MoveState, 1); // Foward
            }
            if (moveY < 0f)
            {
                animator.SetInteger(MoveState, 2); // Back
            }
            if (moveX > 0f)
            {
                animator.SetInteger(MoveState, 3); // Right
            }
            if (moveX < 0f)
            {
                animator.SetInteger(MoveState, 4); // Left
            }

        }




        #endregion
    }
}