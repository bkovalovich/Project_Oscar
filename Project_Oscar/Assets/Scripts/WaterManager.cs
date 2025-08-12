using System.Runtime.CompilerServices;
using UnityEngine;

public class WaterManager : MonoBehaviour
{
    [SerializeField] Transform start, end;
    [SerializeField] int points; 
    private LineRenderer line; 
    private void Awake() {
        line = GetComponent<LineRenderer>();
        CreatePoints();
    }
    private void CreatePoints() {
        line.positionCount = points;
        Vector3 distanceBetween = start.position - end.position;
        Debug.Log($"between: {distanceBetween}");
        float step = Mathf.Abs(distanceBetween.x) / (line.positionCount - 1);
        Debug.Log(step);

        for (int i = 0; i < line.positionCount; i++) {
            line.SetPosition(i, new Vector3(start.position.x + (i * step), start.position.y, 0));
        }
    }
}
