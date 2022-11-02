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

        talkData.Add(1000, new string[] { "�ȳ��ϼ���~" });
        talkData.Add(2000, new string[] { "���� �Ϸ��Դϴ�!"});
        talkData.Add(3000, new string[] { "���� ������ ��������!"});
        talkData.Add(4000, new string[] { "Ai ���а��� �ʹ� �־�..��"});
        talkData.Add(5000, new string[] { "������ ���ƾ�Ф�"});
        talkData.Add(6000, new string[] { "�̹��� ���� ������ �޾Ҵ�~"});
        talkData.Add(7000, new string[] { "���� �Ϸ� �Ǽ���~"});
        talkData.Add(8000, new string[] { "���� �ʹ� ����..!!"});
        talkData.Add(9000, new string[] { "���� ���л�Ȱ ������ �ʹ�~"});

        talkData.Add(1500, new string[] { "����� ����Ÿ�� �Դϴ�." });
        talkData.Add(2500, new string[] { "����� IT���� �Դϴ�." });
        talkData.Add(3500, new string[] { "����� ��õ�� �Դϴ�." });
        talkData.Add(4500, new string[] { "����� �۷ι����� �Դϴ�." });
        talkData.Add(5500, new string[] { "����� �߾ӵ����� �Դϴ�." });
        talkData.Add(6500, new string[] { "����� ���Ǵ��� �Դϴ�." });

        // Quest Talk
        
        talkData.Add(10 + 1000, new string[]
        {
            "�ȳ��ϼ���~ ", "����Ÿ���� ���ּ���!", "��, �˰ڽ��ϴ٤���"
        });

        talkData.Add(11 + 1500, new string[]
        {
            "����Ÿ���� �����߽��ϴ�!", "����Ÿ���� ����4�� ����7�� �Ը� �ǹ��Դϴ�.", "���� �л����� �پ��� ���� ������ ��� ���̰� �����Ǽ���, �л����񽺼���, �л�����ó, ����л���������, â���������� �ֽ��ϴ�!", "������ �� ����~"
        });

        talkData.Add(20 + 2000, new string[]
        {
            "�ȳ��ϼ��䤾�� ", "��õ������ ���ּ���~", "��, �˰ڽ��ϴ�~~"
        });
        talkData.Add(21 + 3500, new string[]
        {
            "��õ�� �����߽��ϴ�!", "��õ���� ����2�� ���� 12�� �Ը��� �ǹ��� ��õ�� �߽ɿ� �ִ� �ǹ��Դϴ�..", "�ǹ� �ȿ��� �����, �̻���ǰ� ���к��ΰ� ��ġ�� ������, ��������ҿ� ���� ������ ��ǰ� �ֽ��ϴ�!", "������ �� �̿����ּ���~"
        });

        talkData.Add(30 + 3000, new string[]
        {
            "�ȳ��ϼ���!! ", "�۷ι����ͷ� ���ּ���~", "��, �˰ڽ��ϴ�!!"
        });
        talkData.Add(31 + 4500, new string[]
        {
            "�۷ι����� �����߽��ϴ�~", "�۷ι����ʹ� 7�� �Ը��� �ǹ��Դϴ�.", "�۷ι����Ϳ����� ���� ���� ���Ǹ� ���� �� �ְ�, ����ó, �������п� �� �ܱ��� �л����� ���� �ѱ��� �������͸� ��ϰ��ֽ��ϴ�!", "�ȳ��� ������~"
        });

        talkData.Add(40 + 4000, new string[]
        {
            "�ȳ��ϼ��䤾�� ", "�߾ӵ��������� ���ּ���!!", "��, �˰ڽ��ϴ� ^-^"
        });
        talkData.Add(41 + 5500, new string[]
        {
            "�߾ӵ����� �����߽��ϴ٤���", "�߾� ������������ �������� �������� �̿��ϽǼ� �ֽ��ϴ�! ����Ⱓ�� �����ϱ� ���� ���ƿ�!", "�׷� ������ ���� �ϼ���!"
        });

        talkData.Add(50 + 5000, new string[]
       {
            "�ȳ��ϼ���~ ", "���Ǵ��аǹ��� ���ּ���!", "��, �˰ڽ��ϴ٤���"
       });
        talkData.Add(51 + 6500, new string[]
        {
            "���Ǵ��� �����߽��ϴ�!", "���Ǵ� ������ ���ǿ����� �����а� �л����� ���Ǹ� ��� �ǹ��Դϴ�.", "������ �� ����!"
        });

        talkData.Add(60 + 6000, new string[]
       {
            "�ȳ��ϼ���^-^ ", "IT���аǹ��� ���ּ���!!", "��, �˰ڽ��ϴ�~"
       });
        talkData.Add(61 + 2500, new string[]
        {
            "IT���� �����߽��ϴ�~", "IT������ IT���� �а� �л����� ���Ǹ� ��� �ǹ��Դϴ�.", "���� �� ��������!"
        });

        talkData.Add(70 + 7000, new string[]
       {
            "�۷ι����� �����߽��ϴ�~", "�۷ι����ʹ� 7�� �Ը��� �ǹ��Դϴ�.", "�۷ι����Ϳ����� ���� ���� ���Ǹ� ���� �� �ְ�, ����ó, �������п� �� �ܱ��� �л����� ���� �ѱ��� �������͸� ��ϰ��ֽ��ϴ�!", "�ȳ��� ������~"
       });
        talkData.Add(71 + 4500, new string[]
        {
            "IT���� �����߽��ϴ�! ������ �� �̿����ּ���~"
        });

        talkData.Add(80 + 8000, new string[]
       {
            "�ȳ��ϼ���~ ", "��õ������ ���ּ��䤾��", "��, �˰ڽ��ϴ�!"
       });
        talkData.Add(81 + 3500, new string[]
        {
            "��õ�� �����߽��ϴ�!", "��õ���� ����2�� ���� 12�� �Ը��� �ǹ��� ��õ�� �߽ɿ� �ִ� �ǹ��Դϴ�..", "�ǹ� �ȿ��� �����, �̻���ǰ� ���к��ΰ� ��ġ�� ������, ��������ҿ� ���� ������ ��ǰ� �ֽ��ϴ�!", "������ �� �̿����ּ���~"
        });

        talkData.Add(90 + 9000, new string[]
{
            "�ȳ��ϼ���! ", "����Ÿ���� ���ּ���~~~", "��, �˰ڽ��ϴ٤���"
});
        talkData.Add(91 + 1500, new string[]
        {
            "����Ÿ���� �����߽��ϴ�!", "����Ÿ���� ����4�� ����7�� �Ը� �ǹ��Դϴ�.", "���� �л����� �پ��� ���� ������ ��� ���̰� �����Ǽ���, �л����񽺼���, �л�����ó, ����л���������, â���������� �ֽ��ϴ�!", "������ �� ����~"
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
