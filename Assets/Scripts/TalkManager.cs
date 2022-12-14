using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    // Update is called once per frame
    void GenerateData()
    {
        // NPC1 : 1000, NPC2 : 2000
        // station1 : 100

        talkData.Add(1000, new string[] { "照括馬室推~" });
        talkData.Add(2000, new string[] { "疏精 馬欠脊艦陥!"});
        talkData.Add(3000, new string[] { "悪税 伸宿備 級生室推!"});
        talkData.Add(4000, new string[] { "Ai 因俳淫精 格巷 菰嬢..ぞ"});
        talkData.Add(5000, new string[] { "獣蝿聖 諺弾嬢ばば"});
        talkData.Add(6000, new string[] { "戚腰拭 疏精 失旋聖 閤紹雁~"});
        talkData.Add(7000, new string[] { "疏精 馬欠 鞠室推~"});
        talkData.Add(8000, new string[] { "劾松 格巷 疏陥..!!"});
        talkData.Add(9000, new string[] { "疏精 企俳持醗 左鎧壱 粛陥~"});

        talkData.Add(1500, new string[] { "食奄澗 搾穿展趨 脊艦陥." });
        talkData.Add(2500, new string[] { "食奄澗 IT企俳 脊艦陥." });
        talkData.Add(3500, new string[] { "食奄澗 亜探淫 脊艦陥." });
        talkData.Add(4500, new string[] { "食奄澗 越稽忽湿斗 脊艦陥." });
        talkData.Add(5500, new string[] { "食奄澗 掻肖亀辞淫 脊艦陥." });
        talkData.Add(6500, new string[] { "食奄澗 廃税企俳 脊艦陥." });

        // Quest Talk
        
        talkData.Add(10 + 1000, new string[]
        {
            "照括馬室推~ ", "搾穿展趨稽 亜爽室推!", "革, 硝畏柔艦陥ぞぞ"
        });

        talkData.Add(11 + 1500, new string[]
        {
            "搾穿展趨拭 亀鐸梅柔艦陥!", "搾穿展趨澗 走馬4寵 走雌7寵 鋭乞拭 闇弘脊艦陥.", "弦精 俳持級戚 陥丞廃 嘘丞 呪穣聖 笈澗 員戚壱 珍坤芝湿斗, 俳持辞搾什湿斗, 俳持差走坦, 舌蕉俳持走据湿斗, 但穣走据舘戚 赤柔艦陥!", "陥製拭 暁 坐推~"
        });

        talkData.Add(20 + 2000, new string[]
        {
            "照括馬室推ぞぞ ", "亜探淫生稽 亜爽室推~", "革, 硝畏柔艦陥~~"
        });
        talkData.Add(21 + 3500, new string[]
        {
            "亜探淫 亀鐸梅柔艦陥!", "亜探淫精 走馬2寵 走雌 12寵 鋭乞税 闇弘稽 亜探企 掻宿拭 赤澗 闇弘脊艦陥..", "闇弘 照拭澗 恥舌叔, 戚紫舌叔引 企俳沙採亜 是帖背 赤生悟, 左闇遭戟社人 差走 古舌戚 錘慎鞠壱 赤柔艦陥!", "陥製拭 暁 戚遂背爽室推~"
        });

        talkData.Add(30 + 3000, new string[]
        {
            "照括馬室推!! ", "越稽忽湿斗稽 亜爽室推~", "革, 硝畏柔艦陥!!"
        });
        talkData.Add(31 + 4500, new string[]
        {
            "越稽忽湿斗 亀鐸梅柔艦陥~", "越稽忽湿斗澗 7寵 鋭乞税 闇弘脊艦陥.", "越稽忽湿斗拭辞澗 慎嬢 嘘丞 悪税研 級聖 呪 赤壱, 脊俳坦, 厩薦嬢俳据 暁 須厩昔 俳持級聖 是廃 廃厩嬢 嘘整湿斗研 錘慎馬壱赤柔艦陥!", "照括備 亜室推~"
        });

        talkData.Add(40 + 4000, new string[]
        {
            "照括馬室推ぞぞ ", "掻肖亀辞淫生稽 亜爽室推!!", "革, 硝畏柔艦陥 ^-^"
        });
        talkData.Add(41 + 5500, new string[]
        {
            "掻肖亀辞淫 亀鐸梅柔艦陥ぞぞ", "掻肖 亀辞淫拭辞澗 亀辞淫引 伸寓叔聖 戚遂馬叔呪 赤柔艦陥! 獣蝿奄娃拭 因採馬奄 舛源 疏焼推!", "益軍 伸宿備 因採 馬室推!"
        });

        talkData.Add(50 + 5000, new string[]
       {
            "照括馬室推~ ", "廃税企俳闇弘稽 亜爽室推!", "革, 硝畏柔艦陥ぞぞ"
       });
        talkData.Add(51 + 6500, new string[]
        {
            "廃税企俳 亀鐸梅柔艦陥!", "廃税企 拭辞澗 廃税森引人 廃税俳引 俳持級戚 悪税研 笈澗 闇弘脊艦陥.", "陥製拭 暁 坐推!"
        });

        talkData.Add(60 + 6000, new string[]
       {
            "照括馬室推^-^ ", "IT企俳闇弘稽 亜爽室推!!", "革, 硝畏柔艦陥~"
       });
        talkData.Add(61 + 2500, new string[]
        {
            "IT企俳 亀鐸梅柔艦陥~", "IT企俳精 IT淫恵 俳引 俳持級戚 悪税研 笈澗 闇弘脊艦陥.", "呪穣 設 級生室推!"
        });

        talkData.Add(70 + 7000, new string[]
       {
            "越稽忽湿斗 亀鐸梅柔艦陥~", "越稽忽湿斗澗 7寵 鋭乞税 闇弘脊艦陥.", "越稽忽湿斗拭辞澗 慎嬢 嘘丞 悪税研 級聖 呪 赤壱, 脊俳坦, 厩薦嬢俳据 暁 須厩昔 俳持級聖 是廃 廃厩嬢 嘘整湿斗研 錘慎馬壱赤柔艦陥!", "照括備 亜室推~"
       });
        talkData.Add(71 + 4500, new string[]
        {
            "IT企俳 亀鐸梅柔艦陥! 陥製拭 暁 戚遂背爽室推~"
        });

        talkData.Add(80 + 8000, new string[]
       {
            "照括馬室推~ ", "亜探淫生稽 亜爽室推ぞぞ", "革, 硝畏柔艦陥!"
       });
        talkData.Add(81 + 3500, new string[]
        {
            "亜探淫 亀鐸梅柔艦陥!", "亜探淫精 走馬2寵 走雌 12寵 鋭乞税 闇弘稽 亜探企 掻宿拭 赤澗 闇弘脊艦陥..", "闇弘 照拭澗 恥舌叔, 戚紫舌叔引 企俳沙採亜 是帖背 赤生悟, 左闇遭戟社人 差走 古舌戚 錘慎鞠壱 赤柔艦陥!", "陥製拭 暁 戚遂背爽室推~"
        });

        talkData.Add(90 + 9000, new string[]
{
            "照括馬室推! ", "搾穿展趨稽 亜爽室推~~~", "革, 硝畏柔艦陥ぞぞ"
});
        talkData.Add(91 + 1500, new string[]
        {
            "搾穿展趨拭 亀鐸梅柔艦陥!", "搾穿展趨澗 走馬4寵 走雌7寵 鋭乞拭 闇弘脊艦陥.", "弦精 俳持級戚 陥丞廃 嘘丞 呪穣聖 笈澗 員戚壱 珍坤芝湿斗, 俳持辞搾什湿斗, 俳持差走坦, 舌蕉俳持走据湿斗, 但穣走据舘戚 赤柔艦陥!", "陥製拭 暁 坐推~"
        });
    }

    public string GetTalk(int id, int talkIndex)
    {
        if(!talkData.ContainsKey(id))
        {
            if(!talkData.ContainsKey(id-id%10))
            {
                return GetTalk(id - id % 100, talkIndex);
            }
            else
            {
                return GetTalk(id - id % 10, talkIndex);
            }
        }
        if(talkIndex==talkData[id].Length)
        {
            return null;
        }
        else
        {
            return talkData[id][talkIndex];
        }    
    }
}
