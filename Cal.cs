using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Cal : MonoBehaviour {

    [System.Serializable]
    public class Asset
    {
        public int id;
        public int bp = 0;
        public int bf = 0;
        public int p = 800;
        public int f = 800;
        public int earn = 0;
        public int lost = 0;
        public int avgP = 0;
        public int avgF = 0;
        public float rate;

    }
    public Asset[] Group = new Asset[11];

    // Use this for initialization
    void Start () {

        //buy
        for (int i = 0; i < Group.Length; i++)
        {
            Group[i].id = i;
            Group[i].f = 800;
            Group[i].p = 800;
        }
        //螢幕P 燒錄機F
        //印表機P 隨身碟F

        Buy(Group[1].id, Group[4].id, "p", 250, 4500);//
        Buy(Group[1].id, Group[4].id, "f", 250, 4500);//

        Buy(Group[1].id, Group[4].id, "f", 150, 4000);
        Buy(Group[1].id, Group[10].id, "f", 200, 4800);
        Buy(Group[1].id, Group[10].id, "p", 200, 3800);

        Buy(Group[1].id, Group[8].id, "f", 100, 7500);//
        Buy(Group[1].id, Group[8].id, "p", 100, 7500);//

        Buy(Group[1].id, Group[8].id, "p", 49, 6000);
        Buy(Group[1].id, Group[10].id, "p", 100, 4800);


        Buy(Group[3].id, Group[10].id, "p", 50, 5250);
        Buy(Group[3].id, Group[10].id, "f", 50, 5250);
        Buy(Group[3].id, Group[6].id, "p", 250, 4500);
        Buy(Group[3].id, Group[6].id, "f", 250, 4500);
        Buy(Group[3].id, Group[2].id, "p", 400, 4335);
        Buy(Group[3].id, Group[2].id, "f", 400, 4335);


        Buy(Group[5].id, Group[10].id, "p", 200, 4250);

        Buy(Group[5].id, Group[10].id, "p", 100, 4200);//
        Buy(Group[5].id, Group[10].id, "f", 100, 4200);//

        Buy(Group[5].id, Group[4].id, "p", 300, 5280);
        Buy(Group[5].id, Group[4].id, "f", 400, 3520);
        Buy(Group[5].id, Group[6].id, "p", 100, 5000);//
        Buy(Group[5].id, Group[6].id, "f", 100, 5000);//
        Buy(Group[5].id, Group[6].id, "f", 100, 4400);

        Buy(Group[7].id, Group[6].id, "p", 300, 4400);
        Buy(Group[7].id, Group[6].id, "f", 300, 4400);

        Buy(Group[7].id, Group[2].id, "p", 50, 4500);
        Buy(Group[7].id, Group[2].id, "p", 150, 4590);
        Buy(Group[7].id, Group[2].id, "f", 50, 3500);
        Buy(Group[7].id, Group[2].id, "f", 150, 3520);

        Buy(Group[7].id, Group[4].id, "p", 100, 4300);
        Buy(Group[7].id, Group[10].id, "p", 100, 3900);
        Buy(Group[7].id, Group[10].id, "f", 200, 3840);

        Buy(Group[9].id, Group[4].id, "p", 150, 4250);
        Buy(Group[9].id, Group[10].id, "p", 150, 4250);
        Buy(Group[9].id, Group[10].id, "f", 250, 4500);
        Buy(Group[9].id, Group[2].id, "p", 200, 4420);
        Buy(Group[9].id, Group[2].id, "f", 100, 3740);
        Buy(Group[9].id, Group[2].id, "f", 50, 3460);
        Buy(Group[9].id, Group[2].id, "f", 50, 3680);

        Buy(Group[9].id, Group[6].id, "f", 50, 4200); //
        Buy(Group[9].id, Group[6].id, "p", 50, 4200);//

        Buy(Group[9].id, Group[8].id, "f", 200, 7500);


        Buy(Group[2].id, Group[7].id, "p", 150, 5000);
        Buy(Group[2].id, Group[7].id, "f", 150, 4200);
        Buy(Group[2].id, Group[9].id, "p", 250, 4800);
        Buy(Group[2].id, Group[9].id, "f", 250, 3570);
        Buy(Group[2].id, Group[9].id, "p", 100, 4000);//
        Buy(Group[2].id, Group[9].id, "f", 100, 4000);//
        Buy(Group[2].id, Group[3].id, "p", 200, 4250);
        Buy(Group[2].id, Group[3].id, "f", 200, 3400);

        Buy(Group[4].id, Group[1].id, "p", 250, 3575);//
        Buy(Group[4].id, Group[1].id, "f", 250, 3575);//
        Buy(Group[4].id, Group[7].id, "p", 300, 3500);//
        Buy(Group[4].id, Group[7].id, "f", 300, 3500);//
        Buy(Group[4].id, Group[9].id, "p", 150, 3600);//
        Buy(Group[4].id, Group[9].id, "f", 150, 3600);//

        Buy(Group[6].id, Group[7].id, "f", 350, 4000);//
        Buy(Group[6].id, Group[7].id, "p", 350, 4000);//
        Buy(Group[6].id, Group[3].id, "f", 200, 4000);//
        Buy(Group[6].id, Group[3].id, "p", 200, 4000);//
        Buy(Group[6].id, Group[5].id, "f", 150, 4250);//
        Buy(Group[6].id, Group[5].id, "p", 150, 4250);//

        Buy(Group[8].id, Group[5].id, "f", 400, 4075);//
        Buy(Group[8].id, Group[5].id, "p", 400, 4075);//
        Buy(Group[8].id, Group[1].id, "f", 100, 2655);//
        Buy(Group[8].id, Group[1].id, "p", 100, 2655);//
        Buy(Group[8].id, Group[3].id, "f", 200, 3800);//
        Buy(Group[8].id, Group[3].id, "p", 200, 3800);//

        Buy(Group[10].id, Group[5].id, "p", 200, 4750);
        Buy(Group[10].id, Group[1].id, "f", 450, 3600);
        Buy(Group[10].id, Group[1].id, "p", 250, 4500);
        Buy(Group[10].id, Group[3].id, "p", 200, 3825);//
        Buy(Group[10].id, Group[3].id, "f", 200, 3825);//
        Buy(Group[10].id, Group[5].id, "p", 50, 4250);//
        Buy(Group[10].id, Group[5].id, "f", 50, 4250);//

        

        float totalCost = 3360000 + 2560000;
 
        
        for (int i = 1; i < Group.Length; i++)
        {
            string itemCate1;
            string itemCate2;

            if ( Group[i].p != 0 || Group[i].f != 0)
            {
                
                Group[i].lost -= Mathf.Abs(Group[i].p) * (Group[i].avgP/800);
                Group[i].lost -= Mathf.Abs(Group[i].f) * (Group[i].avgF/800);

                if (Group[i].id % 2 == 0)
                {
                    itemCate1 = " 個螢幕";
                    itemCate2 = " 個燒錄機";
                }
                else
                {
                    itemCate1 = " 個印表機";
                    itemCate2 = " 個隨身碟";
                }

                Debug.Log("第 " + Group[i].id + " 組的 " + 
                    Group[i].p + itemCate1 + " 和 " + Group[i].f + itemCate2 + " 沒賣完");
                
            }

            if (Group[i].bp != 700 || Group[i].bf != 700)
            {
                

                Group[i].lost -= (700-Group[i].bp) * (Group[i].avgP / 800);
                Group[i].lost -= (700 - Group[i].bf) * (Group[i].avgF / 800);



                if (Group[i].id % 2 == 0)
                {
                    itemCate1 = " 個印表機";
                    itemCate2 = " 個隨身碟";
                }
                else
                {
                    itemCate1 = " 個螢幕";
                    itemCate2 = " 個燒錄機";
                }

                Debug.Log("第 " + Group[i].id + " 組的 " +
                    (700-Group[i].bp) + itemCate1 + " 和 " + (700-Group[i].bf) + itemCate2 + " 沒買齊");

            }


            //float rate = (Group[i].earn - Group[i].lost) / Group[i].earn;
            float earn = Group[i].earn;
            float lost = Mathf.Abs(Group[i].lost);
            float cost = lost + totalCost;

            //float cost = costF + costP;

            float rate = (earn - cost) / earn;

            Debug.Log("第 " + Group[i].id + " 組的獲利率為： " + rate );
            Group[i].rate = rate;
            
            //Group[i].f = 800;
            //Group[i].p = 800;
        }

        //A.Articles = A.Articles.OrderBy(w => w.Distance).ToList();

        Group = Group.OrderBy(item => item.rate).ToArray<Asset>();

        for (int i = 0; i < Group.Length; i++)
        {
            print(Group[i].id + " Rate: " + Group[i].rate);
        }


    }
	
    void Buy(int buyer, int seller, string category, int amount, int price)
    {
        switch (category)
        {
           
            case "p":
                {
                    
                    Group[buyer].bp += amount;
                    Group[seller].p -= amount;
                    //Group[buyer].lost -= amount * price;
                    Group[seller].earn += amount * price;

                    Group[seller].avgP += price * amount;
                }
                break;
            case "f":
                {
                   
                    Group[buyer].bf += amount;
                    Group[seller].f -= amount;
                    //Group[buyer].lost -= amount * price;
                    Group[seller].earn += amount * price;

                    Group[seller].avgF += price * amount;
                }
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }


       

    }

	// Update is called once per frame
	void Update () {
		
	}
}
