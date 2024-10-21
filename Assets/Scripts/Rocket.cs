using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private float fuel = 100f;
    
    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;
    
    void Awake()
    {
        // TODO : Rigidbody2D 컴포넌트를 가져옴(캐싱) 
        _rb2d = GetComponent<Rigidbody2D>();
    }
    
    public void Shoot()
    {
        if(fuel >= FUELPERSHOOT) // 연료가 충분한 경우에만 발사
        {
            fuel -= FUELPERSHOOT; // 연료가 10만큼 소모 체크

            _rb2d.AddForce(Vector2.up * SPEED, ForceMode2D.Impulse); // 위쪽으로*속도가 가해짐
        }
        else
        {
            Debug.Log("연료 부족해! 발사가 불가능해!");
        }
        // TODO : fuel이 넉넉하면 윗 방향으로 SPEED만큼의 힘으로 점프, 모자라면 무시
    }
}
