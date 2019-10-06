using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    //public int health;
    //public int numberOfHearts=2;
    //public Image[] hearts;
    //public Sprite heart;
    //void Update()
    //{
    //    for (int i=0; i < hearts.Length; i++) {
    //        if (i < numberOfHearts)
    //        {
    //            hearts[i].enabled = true;
    //        }
    //        else {
    //            hearts[i].enabled = false;
    //        }
    //    }

    //}
    [SerializeField] private Sprite heartSprite;
    private List<HeartImage> hiList;
    private Hearts h;
    private PlayerHP ph;
    //public int health;
    public int numberOfHearts;
    private void Awake()
    {
        hiList = new List<HeartImage>();
    }


    private void Start()
    {
        HeartImage image1=createHeartImage(new Vector2(-235, 120));
        HeartImage image2=createHeartImage(new Vector2(-225, 120));
        HeartImage image3=createHeartImage(new Vector2(-215, 120));
        HeartImage image4=createHeartImage(new Vector2(-205, 120));
        HeartImage image5=createHeartImage(new Vector2(-195, 120));
        HeartImage image6=createHeartImage(new Vector2(-235, 110));
        HeartImage image7=createHeartImage(new Vector2(-225, 110));
        HeartImage image8=createHeartImage(new Vector2(-215, 110));
        HeartImage image9=createHeartImage(new Vector2(-205, 110));
        HeartImage image10=createHeartImage(new Vector2(-195, 110));
    }
    public void setCurrentHealth(int c) {
        numberOfHearts = c;
    }
    void Update()
    {
        numberOfHearts = ph.getHealth();
        for (int i = 0; i < hiList.Capacity; i++)
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
        go.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(10, 10);

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
