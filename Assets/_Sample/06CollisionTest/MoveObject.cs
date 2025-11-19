using UnityEngine;

namespace MySample
{
    /// <summary>
    /// 오브젝트의 이동 구현 : 리지바디의 힘을 이용
    /// </summary>
    public class MoveObject : MonoBehaviour
    {
        #region Variables
        //참조
        Rigidbody rb;

        //입력 값(좌,우)
        float moveX;
        //이동 힘
        float movePower = 10f;
        public Material redMaterial;

        Renderer renderer;
        Material originMaterial;
        #endregion

        #region Unity Event Method
        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            renderer = GetComponent<Renderer>();
        }
        private void Update()
        {
            //좌우 입력
            moveX = Input.GetAxis("Horizontal");
        }
        private void FixedUpdate()
        {
            //힘에 의한 오브젝트 좌우 이동
            rb.AddForce(Vector3.right * moveX * movePower, ForceMode.Force);
        }
        #endregion

        #region Custom Method
        //왼쪽으로 힘 (200f)
        public void MoveLeft()
        {
            rb.AddForce(Vector3.left * moveX * movePower, ForceMode.Impulse);
        }
        public void MoveRight()
        {
            rb.AddForce(Vector3.right * moveX * movePower, ForceMode.Impulse);
        }
        public void ChangeMoveColor()
        {
            renderer.material = redMaterial;
        }
        public void ResetMoveColor()
        { 
            renderer.material = originMaterial;
        }
        #endregion

    }
}