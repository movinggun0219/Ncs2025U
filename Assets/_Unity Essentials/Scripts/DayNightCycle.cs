using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("현실 시간(초) 기준으로 하루가 몇 초에 지나가는지 설정하세요 (360도 회전 기준).")]
    [SerializeField] private float dayDurationInSeconds = 120f;

    private void Update()
    {
        // 0초 이하로 설정되면 회전을 막음
        if (dayDurationInSeconds <= 0f) return;

        // 초당 회전할 각도 계산 (하루 = 360도)
        float rotationSpeed = 360f / dayDurationInSeconds;

        // x축 기준으로 회전 (Time.deltaTime은 프레임 간 시간 보정)
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
