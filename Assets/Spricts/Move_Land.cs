using UnityEngine;
using UnityEngine.InputSystem;

public class Move_Land : MonoBehaviour
{
    private InputAction _plyaerInput;
    [SerializeField]
    private GameObject _stage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // InputSystem.actions.FindAction("Move")
        // InputSystemのアクションマップから"Move"という名前のアクションを探して取得する
        _plyaerInput = InputSystem.actions.FindAction("Move");
    }

    // 1フレームごとにアップデート関数が呼ばれる
    void Update()
    {
        //_playerInputの値によってステージを回転させる
        Debug.Log(_plyaerInput.ReadValue<Vector2>());

        float horizontalInput = _plyaerInput.ReadValue<Vector2>().x;
        float verticalInput = _plyaerInput.ReadValue<Vector2>().y;

        _stage.transform.Rotate(horizontalInput,0f,verticalInput);
    }
}
