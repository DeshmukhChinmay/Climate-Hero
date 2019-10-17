using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    [SerializeField] private Sprite heartSprite;
    private List<HeartImage> hiList;
    private Hearts h;
    public int numberOfHearts;
    private void Awake()
    {
        hiList = new List<HeartImage>();
    }


    private void Start()
    {
        GameObject thePlayer = GameObject.Find("PlayerCollider");
        PlayerHP playerScript = thePlayer.GetComponent<PlayerHP>();
        numberOfHearts = playerScript.health;
        HeartImage image1 = createHeartImage(new Vector2(0, 0));
        HeartImage image2 = createHeartImage(new Vector2(50, 0));
        HeartImage image3 = createHeartImage(new Vector2(100, 0));
        HeartImage image4 = createHeartImage(new Vector2(150, 0));
        HeartImage image5 = createHeartImage(new Vector2(200, 0));
        HeartImage image6 = createHeartImage(new Vector2(0, 50));
        HeartImage image7 = createHeartImage(new Vector2(50, 50));
        HeartImage image8 = createHeartImage(new Vector2(100, 50));
        HeartImage image9 = createHeartImage(new Vector2(150, 50));
        HeartImage image10 = createHeartImage(new Vector2(200, 50));
    }
    public void Update()
    {
        GameObject thePlayer = GameObject.Find("PlayerCollider");
        PlayerHP playerScript = thePlayer.GetComponent<PlayerHP>();
        numberOfHearts = playerScript.health;
        for (int i = 0; i < 10; i++)
        {
            if (i < numberOfHearts)
            {
                hiList[i].Set(1);
            }
            else
            {
                hiList[i].Set(0);
            }
        }

    }

    private HeartImage createHeartImage(Vector2 anchorPosit)
    {
        GameObject go = new GameObject("Heart", typeof(Image));
        go.transform.parent = transform;
        go.transform.localPosition = Vector3.zero;

        go.transform.GetComponent<RectTransform>().anchoredPosition = anchorPosit;
        go.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(25, 25);

        Image heartImageUI = go.GetComponent<Image>();
        heartImageUI.sprite = heartSprite;
        HeartImage heartImage = new HeartImage(h, heartImageUI);
        hiList.Add(heartImage);
        return heartImage;
    }

    public class HeartImage
    {
        private Image heartImage;
        private Hearts hearts;
        public HeartImage(Hearts h, Image image)
        {
            heartImage = image;
            hearts = h;
        }
        public void Set(int h)
        {
            if (h == 1)
            {
                heartImage.enabled = true;
            }
            else
            {
                heartImage.enabled = false;
            }
        }
    }
}
