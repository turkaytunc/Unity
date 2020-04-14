using UnityEngine;


public class Block : MonoBehaviour
{
    [SerializeField] private GameObject tmPro;
    [SerializeField] private AudioClip[] audioClips;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(audioClips[Random.Range(0, audioClips.Length)], Camera.main.transform.position, 0.5f);
        tmPro.GetComponent<Score>().currentScore += 1;
        Destroy(gameObject);
    }
}
