using UnityEngine;

namespace MySample
{
    public class AnimatorLayersTest : MonoBehaviour
    {
        private Animator animator;
        private string IsWalk = "IsWalk";

        public bool Walk
        {
            get
            {
                return animator.GetBool(IsWalk);
            }
        }

        private void Awake()
        {
            //참조
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            //걷기
            if (Input.GetKeyDown(KeyCode.W))
            {
                animator.SetBool(IsWalk, true);
                animator.SetLayerWeight(1, 1f); //조준 그리기
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                animator.SetBool(IsWalk, false);
                animator.SetLayerWeight(1, 0f); //조준 그리기
            }
        }

    }
}