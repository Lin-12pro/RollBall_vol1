using UnityEngine;

public class GoalArea : MonoBehaviour
{
    public GameObject GoalText;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("ゴールした！");
            GoalText.SetActive(true);
        }
    }
}
