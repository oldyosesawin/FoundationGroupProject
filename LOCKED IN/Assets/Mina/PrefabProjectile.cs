using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabProjectile : MonoBehaviour
{
    private Vector3 targetPosition;
    private float moveSpeed;
    private bool isTargetSet = false;

    // ฟังก์ชันสำหรับรับค่าจุดหมายและความเร็วจากตัวคุมยิง
    public void Setup(Vector3 target, float speed)
    {
        targetPosition = target;
        moveSpeed = speed;
        isTargetSet = true;
    }

    private void Update()
    {
        if (!isTargetSet) return;

        // เคลื่อนที่ Prefab พุ่งไปยังจุดเป้าหมาย
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // เมื่อวิ่งไปถึงจุดเป้าหมายแล้ว ให้ทำลาย Prefab ทิ้ง (ป้องกันเกมกระตุก)
        if (Vector3.Distance(transform.position, targetPosition) < 0.05f)
        {
            Destroy(gameObject);
        }
    }
}
