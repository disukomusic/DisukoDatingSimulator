using UnityEngine;
public class Charachter : MonoBehaviour
{
    public Sprite portrait;
    public bool isActive;
    public int id;
    LTDescr tween;

    public void MoveTo(Position pos) 
    {

    }
    public void SetUnactive()
    {
        if (!isActive) return;
        isActive = false;
        //Fade out
    }
    public void SetActive()
    {
        if (isActive) return;
        isActive = true;
        //Fade in
    }
    public void SetActive(Position location)
    {
        if (isActive) return;
        isActive = true;    
        //Will prob rework to only take in a set amount of points
        GetComponent<RectTransform>().anchoredPosition = new Vector2((int)location, 0);

        //Fade in
    }
}
public enum Position
{
    Left = -450,
    Right = 450,
    Center = 0
}