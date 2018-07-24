using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Per que funcioni fins i tot en el modo editor
[ExecuteInEditMode]

public class CardRotation : MonoBehaviour {
    public RectTransform cardFront;
    public RectTransform cardBack;
    public Transform targetFacePoint;
    public Collider col;

    private bool showingBack = false;

    private void Update()
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(origin: Camera.main.transform.position + targetFacePoint.position,
            direction: (-Camera.main.transform.position + targetFacePoint.position).normalized,
            maxDistance: (-Camera.main.transform.position + targetFacePoint.position).magnitude);

        bool passedTroughTargetCollider = false;

        foreach (RaycastHit h in hits)
        {
            if (h.collider == col)
            {
                passedTroughTargetCollider = true;
            }
        }

        if(passedTroughTargetCollider != showingBack)
        {
            showingBack = passedTroughTargetCollider;
            if (showingBack)
            {
                cardFront.gameObject.SetActive(false);
                cardBack.gameObject.SetActive(true);
            }

            else
            {
                cardFront.gameObject.SetActive(true);
                cardBack.gameObject.SetActive(false);
            }
        }
    }
}

