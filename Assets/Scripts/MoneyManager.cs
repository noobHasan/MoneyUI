using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{

    [Header("Objects for Money")]
    public GameObject moneyPrefab;
    public GameObject moneyIcon;
    public TextMeshProUGUI moneyText;
    public List<Transform> moneyList = new List<Transform>();

    [Header("Variables for Money")]
    public int money;
    public Transform moneySpawnPos;

    [Header("Scripts")]
    private MoneyManagerTween _moneyTweenScr;

    public static MoneyManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        moneySpawnPos = PlayerController.Instance.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateMoneyList()
    {
        for (int i = 0; i < 100; i++)
        {
            Transform money = Instantiate(moneyPrefab.transform);
            money.parent = transform;
            money.gameObject.SetActive(false);
            moneyList.Add(money);
        }
    }

    public IEnumerator GetMoney() 
    {
        yield return new WaitForSeconds(0.5f);
    }
}
