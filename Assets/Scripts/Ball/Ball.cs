using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool iSFinish = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlatformSegment platformSegment))
        {
            platformSegment.GetComponentInParent<Platform>().Break();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out PlatformSegment platformSegment))
        {
            if (platformSegment.GetComponentInParent<FinishPlatform>() && !iSFinish)
            {
                iSFinish = true;
                Debug.Log("Вы достигли финиша!!!");
            }
        }
    }
}
