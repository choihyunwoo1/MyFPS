using UnityEngine;

namespace Sample
{
    /// <summary>
    /// 큐브 컬러를 흰색에서 빨간색으로 바꾸기
    /// 메터리얼 속성 값 접근하여 사용하기
    /// Render - material
    /// </summary>
    public class MaterialTest : MonoBehaviour
    {
        #region Variables
        //참조
        Renderer renderer;

        public Material redMaterial;
        #endregion

        #region Unity Event Method
        private void Awake()
        {
            //참조
            renderer = GetComponent<Renderer>();
        }
        private void Update()
        {
            //키 입력 처리
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //ChangeMaterial();
                ChangeMaterialColor();
            }
        }
        #endregion

        #region Custom Method
        //메터리얼 변경하기
        void ChangeMaterial()
        { 
            renderer.material = redMaterial;
        }
        //메터리얼 컬러 변경하기
        void ChangeMaterialColor()
        {
            renderer.material.SetColor("_BaseColor", Color.red);
        }
        #endregion
    }
}