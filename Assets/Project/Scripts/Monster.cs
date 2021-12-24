/* Script Created by Crimsonshade
 * ALl rights reseverd Kappa
 */

using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        transform.position = spawnPoint.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger("Down");
        }
    }
}
