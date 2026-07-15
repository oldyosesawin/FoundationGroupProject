using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamSpawnerController : MonoBehaviour
{

   
    [SerializeField] private Transform spawnPoint;

    
    [SerializeField] private GameObject projectilePrefab;

   
    [SerializeField] private List<Transform> targetPoints = new List<Transform>();

   
    [SerializeField] private float projectileSpeed = 10.0f;

    
    [SerializeField] private float startDelay = 2.0f;

    
    [SerializeField] private float fireRate = 0.5f;

    private bool isAutoFiring = false;
    private Coroutine autoFireCoroutine;

   
    public void OnButtonClick()
    {
        
        if (!isAutoFiring)
        {
            StartAutoFire();
        }
        else
        {
            StopAutoFire();
        }
    }

    public void StartAutoFire()
    {
        if (!isAutoFiring)
        {
            isAutoFiring = true;
            autoFireCoroutine = StartCoroutine(AutoFireRoutine());
        }
    }

    public void StopAutoFire()
    {
        if (isAutoFiring)
        {
            isAutoFiring = false;
            if (autoFireCoroutine != null)
            {
                StopCoroutine(autoFireCoroutine);
            }
        }
    }

    private IEnumerator AutoFireRoutine()
    {
       
        yield return new WaitForSeconds(startDelay);

       
        while (isAutoFiring)
        {
            ShootOnePrefab();
            yield return new WaitForSeconds(fireRate);
        }
    }

    private void ShootOnePrefab()
    {
        if (spawnPoint == null || projectilePrefab == null || targetPoints == null || targetPoints.Count == 0)
        {
            Debug.LogWarning("กรุณาตั้งค่า Inspector ให้ครบถ้วน!");
            return;
        }

       
        int randomIndex = Random.Range(0, targetPoints.Count);
        Transform selectedTarget = targetPoints[randomIndex];

        if (selectedTarget != null)
        {
            GameObject newProjectile = Instantiate(projectilePrefab, spawnPoint.position, Quaternion.identity);

            PrefabProjectile script = newProjectile.GetComponent<PrefabProjectile>();
            if (script == null)
            {
                script = newProjectile.AddComponent<PrefabProjectile>();
            }

            script.Setup(selectedTarget.position, projectileSpeed);
        }
    }
}

