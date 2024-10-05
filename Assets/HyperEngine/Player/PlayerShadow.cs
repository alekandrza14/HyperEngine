using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShadow : MonoBehaviour
{
    private Vector3 origScale;
    private HyperObject ho;
    public Material _object;

    void Awake() {
        ho = GetComponent<HyperObject>();
        origScale = transform.localScale;
    }

    private void Start() {
        transform.localScale = origScale * FindFirstObjectByType<Player>().ScaleFactor();
    }

    void Update() {
        ho.localGVD = -HyperObject.worldGVD;
    }
}
