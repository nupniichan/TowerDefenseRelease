using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 30f;

    public float scrollSpeed = 30f;
    public float minY = 10f;
    public float maxY = 120f;
    private void Update()
    {
        if (GameManager.isGameOver)
        {
            this.enabled = false;
            return;
        }

        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxisRaw("Mouse ScrollWheel");

        Vector3 positionScroll = transform.position;

        positionScroll.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
        positionScroll.y = Mathf.Clamp(positionScroll.y, minY, maxY);
        transform.position = positionScroll;

        if (Input.GetKey("space"))
        {
            transform.position = new Vector3(42, 120, -93.43f);
        }
    }
}
