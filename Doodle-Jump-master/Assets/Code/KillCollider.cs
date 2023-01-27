using UnityEngine;

public class KillCollider : MonoBehaviour
{
    public GameObject win; 
    private GameObject finishScreen;

    private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.transform.CompareTag("Player"))
		{
			GameManager.Instance.GameOver();
            win.SetActive(true);
            Debug.Log("bitis");
        }
	}
}