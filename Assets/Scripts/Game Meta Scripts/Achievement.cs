using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievement : MonoBehaviour
{
    public int numOfStars = 1;
    [SerializeField] Sprite star;
    private List<StarImage> starList;
    private Achievement a;

    private void Awake()
    {
        starList = new List<StarImage>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //  GameObject thePlayer = GameObject.Find("PlayerCollider");
        // PlayerHP playerScript = thePlayer.GetComponent<PlayerHP>();
        //numOfStars = playerScript.achievement;
        Scores.Stop();
        
       
        int enemies = Scores.enemiesDefeated;
        int sideQuest = Scores.seedCollected;
       
        if (enemies > 10)
        {
            numOfStars++;
        }
        if (sideQuest > 9)
        {
            numOfStars++;
        }
        StarImage image1 = createStarImage(new Vector2(0, 10));
        StarImage image2 = createStarImage(new Vector2(70, 10));
        StarImage image3 = createStarImage(new Vector2(140, 10));
        showStars(numOfStars);
    }

    public void showStars(int num)
    {
        for( int i = 0; i < num; i++)
        {
            starList[i].Set(1);
        }
    }

    private StarImage createStarImage(Vector2 anchorPosit)
    {
        GameObject go = new GameObject("Star", typeof(Image));
        go.transform.parent = transform;
        go.transform.localPosition = Vector3.zero;

        go.transform.GetComponent<RectTransform>().anchoredPosition = anchorPosit;
        go.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);

        Image starImageUI = go.GetComponent<Image>();
        starImageUI.sprite = star;
        StarImage starImage = new StarImage(a, starImageUI);
        starList.Add(starImage);
        return starImage;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public class StarImage
    {
        private Image starImage;
        private Achievement stars;
        public StarImage(Achievement a, Image image)
        {
            starImage = image;
            stars = a;
        }
        public void Set(int num)
        {
            if (num == 1)
            {
                starImage.enabled = true;
            }
            else
            {
                starImage.enabled = false;
            }
        }
    }
}
