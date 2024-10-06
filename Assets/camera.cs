using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // 角色的Transform
    public Vector3 offset = new Vector3(0, 5, -10);  // 攝影機相對於角色的偏移
    public float smoothSpeed = 0.125f;  // 攝影機移動的平滑速度

    void LateUpdate()
    {
        // 計算目標位置
        Vector3 desiredPosition = target.position + offset;
        
        // 平滑過渡到目標位置
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        
        // 更新攝影機位置
        transform.position = smoothedPosition;

        // 攝影機朝向角色
        transform.LookAt(target);
    }
}
