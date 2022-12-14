using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps; 

public class CameraSegue : MonoBehaviour
{
    public Transform target;
    private float xMin, xMax, yMin, yMax;
    [SerializeField]
    private Tilemap tileM;
    private Vector3 minTile, maxTile;

    void Start()
    {
        minTile = tileM.CellToWorld(tileM.cellBounds.min);
        maxTile = tileM.CellToWorld(tileM.cellBounds.max);

        Limits(minTile, maxTile);
    }

    void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x, xMin, xMax), Mathf.Clamp(target.position.y, yMin, yMax), -10);

    }




void Limits (Vector3 minTile, Vector3 maxTile)
    {
        Camera cam = Camera.main;
        float altura = 2f * cam.orthographicSize;
        float largura = altura * cam.aspect;

        xMin = minTile.x + largura / 2;
        xMax = maxTile.x - largura / 2;
        yMin = minTile.y + altura / 2;
        yMax = maxTile.y - altura / 2;
    }
}
