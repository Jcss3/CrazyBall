using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBarra : MonoBehaviour
{

    [SerializeField] private Color _normalColor = new Color(0,0,0);
    [SerializeField] private Color _highlightColor = new Color(255, 0, 0);
    [SerializeField] private Color _activeColor = new Color(255, 255, 255);

    private SpriteRenderer _renderer; // All renderers inherit from Renderer.

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _renderer.material.color = _normalColor;
    }

    private void OnMouseEnter()
    {
        _renderer.material.color = _highlightColor;
    }

    private void OnMouseDown()
    {
        _renderer.material.color = _activeColor;
    }

    private void OnMouseExit()
    {
        _renderer.material.color = _normalColor;
    }

    private void OnMouseUpAsButton()
    {
        _renderer.material.color = _highlightColor;
    }

}
